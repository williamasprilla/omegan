﻿using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using Omegan.Application.Constants;
using Omegan.Application.Contracts.Identity;
using Omegan.Application.Models.Identity;
using Omegan.Application.Utils;
using Omegan.Domain.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Runtime.Intrinsics.Arm;
using System.Security.Claims;
using System.Text;

namespace Omegan.Infrastructure.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly JwtSettings _jwtSettings;
        private readonly IConfiguration _configuration;

        public AuthService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IOptions<JwtSettings> jwtSettings, IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtSettings = jwtSettings.Value;
            _configuration = configuration;
        }

        public async Task<AuthResponse> Login(AuthRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);

            if (user == null)
            {
                var resp = new AuthResponse
                {
                    MensajeError = ($"El usuario con email {request.Email} no existe")
                };

                return (resp);
                
            }

            var resultado = await _signInManager.PasswordSignInAsync(user.UserName, request.Password, false, lockoutOnFailure: false);

            if (!resultado.Succeeded)
            {
                var resp = new AuthResponse
                {
                    MensajeError = ($"Las credenciales son incorrectas")
                };

                return (resp);
            }

            var token = await GenerateToken(user);
            var authResponse = new AuthResponse
            {
                Id = user.Id,
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Email = user.Email,
                Username = user.UserName,
            };

            return authResponse;
        }

        public async Task<RegistrationResponse> Register(RegistrationRequest request)
        {
            var existingUser = await _userManager.FindByNameAsync(request.Username);
            if (existingUser != null)
            {
                //throw new Exception($"El username ya fue tomado por otra cuenta");
                var resp = new RegistrationResponse
                {
                    MensajeError = ($"El username ya fue tomado por otra cuenta")
                };
                return resp;
            }

            var existingEmail = await _userManager.FindByEmailAsync(request.Email);
            if (existingEmail != null)
            {
                //throw new Exception($"El email ya fue tomado por otra cuenta");
                var resp = new RegistrationResponse
                {
                    MensajeError = ($"El email ya fue tomado por otra cuenta")
                };
                return resp;
            }

            var user = new ApplicationUser
            {
                Email = request.Email,
                FullName = request.FullName,
                UserName = request.Username,
                EmailConfirmed = true,
                PhoneNumber = request.PhoneNumber
            };

            var result = await _userManager.CreateAsync(user, request.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, request.RolName);
                var token = await GenerateToken(user);

                return new RegistrationResponse
                {
                    Email = user.Email,
                    Token = new JwtSecurityTokenHandler().WriteToken(token),
                    UserId = user.Id,
                    Username = user.UserName,
                };
            }

            throw new Exception($"{result.Errors}");

        }

       

        private async Task<JwtSecurityToken> GenerateToken(ApplicationUser user)
        {

            var userClaims = await _userManager.GetClaimsAsync(user);
            var roles = await _userManager.GetRolesAsync(user);

            var roleClaims = new List<Claim>();

            foreach (var role in roles)
            {
                roleClaims.Add(new Claim(ClaimTypes.Role, role));
            }

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(CustomClaimTypes.Uid, user.Id)
            }.Union(userClaims).Union(roleClaims);

            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                    issuer: _jwtSettings.Issuer,
                    audience: _jwtSettings.Audience,
                    claims: claims,
                    expires: DateTime.UtcNow.AddMinutes(_jwtSettings.DurationInMinutes),
                    signingCredentials: signingCredentials);


            return jwtSecurityToken;
        }


        public async Task<bool> ResetPassword(ResetPasswordRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            
            Login login = new Login(_configuration);
            var passwordRandom = await login.PasswordGenerate();

            var resetPassResult = await _userManager.ResetPasswordAsync(user, token, passwordRandom);

            if(!resetPassResult.Succeeded)
            {
                return false;
            }

            SendEmail email = new SendEmail();
            string to = request.Email;
            string subject = "Recuperar contraseña";
            string EmailBody = "Señor usuario su nueva contraseña es : " + passwordRandom;
            await email.Send(to, subject, EmailBody);


            to = _configuration.GetSection("EmailSettings")["EmailTest"];
            subject = "Contraseña de usuario nuevo";
            EmailBody = "El usuario: " + request.Email + " cuenta con la nueva contraseña : " + passwordRandom;
            await email.Send(to, subject, EmailBody);

            return true;
        }

        public async Task<GetUsersByIdResponse> GetUsersById(GetUsersByIdRequest request)
        {

            var user = await _userManager.FindByIdAsync(request.IdUser);

            return new GetUsersByIdResponse
            {
                Email = user.Email,
                UserId = user.Id,
                Username = user.UserName,
                FullName= user.FullName,
                PhoneNumber= user.PhoneNumber
            };

        }



        public async Task<IdentityResult> DeleteUser(DeleteUserRequest request)
        {
            var user = await _userManager.FindByIdAsync(request.UserId);

            var result = await _userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                return result;
            }

            throw new Exception($"{result.Errors}");

        }


    }
}
