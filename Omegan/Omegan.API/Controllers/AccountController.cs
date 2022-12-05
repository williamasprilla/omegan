using Microsoft.AspNetCore.Mvc;
using Omegan.Application.Contracts.Identity;
using Omegan.Application.Models.Identity;
using Omegan.Application.Utils;

namespace Omegan.API.Controllers
{

    public class AccountController : ApiControllerBase
    {
        private readonly IAuthService _authService;

        public AccountController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] AuthRequest request)
        {
            var result = await _authService.Login(request);

            return new OkObjectResult(new ResultResponse(result));
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegistrationRequest request)
        {
            var result = await _authService.Register(request);

            return new OkObjectResult(new ResultResponse(result) { Message = string.Format(ResultResponse.ENTITY_INSERT_OK, result.UserId) });
        }


        [HttpPost("ResetPassword")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordRequest request)
        {
            var result = await _authService.ResetPassword(request);

            return new OkObjectResult(new ResultResponse(result) { Message = string.Format(ResultResponse.ENTITY_INSERT_OK, request.Email) });
        }

    }
}
