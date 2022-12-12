using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Omegan.Application.Features.Archives.Commands.CreateArchive;
using Omegan.Application.Features.Companies.Queries.GetCompanyByIdWithArchives;
using Omegan.Application.Utils;
using Omegan.Domain;
using System.Net;

namespace Omegan.API.Controllers
{
    
    public class EmailController : ApiControllerBase
    {
       
        [HttpGet("SendEmail")]
        public async Task<IActionResult> SendEmail(string to, string subject, string emailBody)
        {
            SendEmail email = new SendEmail();

            await email.Send(to, subject, emailBody);

            return new OkObjectResult(new ResultResponse(Ok("Ok")) { Message = string.Format(ResultResponse.ENTITY_INSERT_OK, Ok("Ok")) });
        }

    }
}
