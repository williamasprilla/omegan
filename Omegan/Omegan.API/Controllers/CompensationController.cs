using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Omegan.Application.Features.Announcements.Commands.UpdateAnnouncement;
using Omegan.Application.Features.Companies.Queries.GetAllCompanyAnnouncements;
using Omegan.Application.Features.Compensation.Commands.CreateCompensation;
using Omegan.Application.Features.Compensation.Commands.UpdateCompensation;
using Omegan.Application.Utils;
using System.Net;

namespace Omegan.API.Controllers
{
   
    public class CompensationController : ApiControllerBase
    {
        private IMediator _mediator;

        public CompensationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [ProducesResponseType((int) HttpStatusCode.OK)]
        [HttpPost("RegisterCompensation")]
        public async Task<IActionResult> CreateCompensation([FromBody] CreateCompensationCommandMapper command)
        {
            var result = await _mediator.Send(command);
            return new OkObjectResult(new ResultResponse(result) { Message = string.Format(ResultResponse.ENTITY_INSERT_OK, result) });
        }



        [HttpPut("UpdateCompensation")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateCompensation([FromBody] UpdateCompensationCommandMapper command)
        {
            var result = await _mediator.Send(command);
            return new OkObjectResult(new ResultResponse(result) { Message = string.Format(ResultResponse.ENTITY_INSERT_OK, result) });
        }



        //[HttpGet("GetAllCompanyCompensation")]
        //public async Task<IActionResult> GetAllCompanyCompensation()
        //{
        //    var query = new GetAllCompanyAnnouncementsQuery();
        //    var company = await _mediator.Send(query);
        //    return new OkObjectResult(new ResultResponse(company) { Message = string.Format(ResultResponse.ENTITY_GET, company) });
        //}



    }
}
