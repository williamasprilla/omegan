using Microsoft.AspNetCore.Mvc;
using Omegan.Application.Contracts.Identity;
using Omegan.Application.Features.Companies.Queries.GetCompanyById;
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

            if(!string.IsNullOrEmpty(result.MensajeError))
            {
                return new OkObjectResult(new ResultResponse(result) { Success = false, Message = string.Format(result.MensajeError, result) });
            }
            return new OkObjectResult(new ResultResponse(result) { Message = string.Format(ResultResponse.ENTITY_INSERT_OK, result.Id) });


        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegistrationRequest request)
        {
            var result = await _authService.Register(request);

            if (!string.IsNullOrEmpty(result.MensajeError))
            {
                return new OkObjectResult(new ResultResponse(result) { Success = false, Message = string.Format(result.MensajeError, result) });
            }
            return new OkObjectResult(new ResultResponse(result) { Message = string.Format(ResultResponse.ENTITY_INSERT_OK, result.UserId) });
        }


        [HttpPost("ResetPassword")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordRequest request)
        {
            var result = await _authService.ResetPassword(request);

            return new OkObjectResult(new ResultResponse(result) { Message = string.Format(ResultResponse.ENTITY_INSERT_OK, request.Email) });
        }


        [HttpPost("GetUsersById")]
        public async Task<IActionResult> GetUsersById(GetUsersByIdRequest request)
        {
            var company = await _authService.GetUsersById(request);
            return new OkObjectResult(new ResultResponse(company) { Message = string.Format(ResultResponse.ENTITY_GET, company) });
        }

    }
}
