﻿using Omegan.Application.Models.Identity;

namespace Omegan.Application.Contracts.Identity
{
    public interface IAuthService
    {
        Task<AuthResponse> Login(AuthRequest request);
        Task<RegistrationResponse> Register(RegistrationRequest request);

        Task<bool> ResetPassword(ResetPasswordRequest request);
        Task<GetUsersByIdResponse> GetUsersById(GetUsersByIdRequest request);
        
    }
}
