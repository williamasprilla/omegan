using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Omegan.Application.Features.Companies.Queries.GetCountries;
using Omegan.Application.Features.Countries.Commands.UpdateCountry;
using Omegan.Application.Features.TRM.Commands.CreateTRM;
using Omegan.Application.Features.TRM.Commands.UpdateTRM;
using Omegan.Application.Features.TRM.Queries;
using Omegan.Application.Utils;
using Omegan.Domain;
using System.Net;

namespace Omegan.API.Controllers
{
    
    public class TRMController : ApiControllerBase
    {
        private IMediator _mediator;
        public TRMController(IMediator mediator)
        {
            _mediator = mediator;
        }




        [ProducesResponseType((int)HttpStatusCode.OK)]
        [HttpPost("CreateTRM")]
        public async Task<IActionResult> CreateTRM([FromBody] CreateTRMCommandMapper command)
        {
            var result = await _mediator.Send(command);
            return new OkObjectResult(new ResultResponse(result) { Message = string.Format(ResultResponse.ENTITY_INSERT_OK, result) });
        }


        [HttpGet("GetTRM")]
        public async Task<IActionResult> GetTRM()
        {
            var query = new GetTRMListQuery();
            var trm = await _mediator.Send(query);
            return new OkObjectResult(new ResultResponse(trm) { Message = string.Format(ResultResponse.ENTITY_GET, trm) });
        }


        [HttpPut("UpdateTRM")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateTRM([FromBody] UpdateTRMCommandMapper command)
        {
            var result = await _mediator.Send(command);
            return new OkObjectResult(new ResultResponse(result) { Message = string.Format(ResultResponse.ENTITY_INSERT_OK, result) });
        }

    }
}
