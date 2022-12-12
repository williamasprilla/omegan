using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Omegan.Application.Features.Companies.Queries.GetCompanyByIdWithArchives;
using Omegan.Application.Utils;
using Omegan.Domain;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Omegan.API.Controllers
{
    
    public class EmailController : ApiControllerBase
    {

        [HttpGet("SendEmail")]
        public async Task<IActionResult> SendEmail(string to, string subject, string emailBody)
        {
            SendEmail email = new SendEmail();

            var result = await _mediator.Send(command);

            return new OkObjectResult(new ResultResponse(result) { Message = string.Format(ResultResponse.ENTITY_INSERT_OK, result) });

        }
    }
}
