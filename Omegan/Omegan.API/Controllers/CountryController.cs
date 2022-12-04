using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Omegan.Application.Features.Companies.Commands.CreateCompany;
using Omegan.Application.Features.Companies.Queries.GetCompanyByIdWithArchives;
using Omegan.Application.Features.Companies.Queries.GetCountries;
using Omegan.Application.Features.Countries.Commands.CreateCountry;
using Omegan.Application.Features.Countries.Commands.DeleteCountry;
using Omegan.Application.Features.Countries.Commands.UpdateCountry;
using Omegan.Application.Utils;
using System.Net;

namespace Omegan.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ApiControllerBase
    {
        private IMediator _mediator;

        public CountryController(IMediator mediator)
        {
            _mediator = mediator;
        }



        [ProducesResponseType((int)HttpStatusCode.OK)]
        [HttpPost("CreateCountry")]
        public async Task<IActionResult> CreateCountry([FromBody] CreateCountryCommandMapper command)
        {

            var result = await _mediator.Send(command);

            return NoContent();
        }


        [HttpGet("GetAllCountry")]
        public async Task<IActionResult> GetAllCountry()
        {
            var query = new GetAllCountriesQuery();
            var country = await _mediator.Send(query);
            return new OkObjectResult(new ResultResponse(country) { Message = string.Format(ResultResponse.ENTITY_GET, country) });
        }


        [HttpGet("GetCountryById")]
        public async Task<IActionResult> GetCountryById(int userid)
        {
            var query = new GetCountriesQuery(userid);
            var country = await _mediator.Send(query);
            return new OkObjectResult(new ResultResponse(country) { Message = string.Format(ResultResponse.ENTITY_GET, country) });
        }



        [HttpPut("UpdateCountry")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateCountry([FromBody] UpdateCountryCommandMapper command)
        {

            var result = await _mediator.Send(command);

            return new OkObjectResult(new ResultResponse(result) { Message = string.Format(ResultResponse.ENTITY_INSERT_OK, result) });
        }



        [HttpDelete("{id}", Name = "DeleteCountry")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteCountry(int id)
        {
            var command = new DeleteCountryCommandMapper
            {
                Id = id
            };

            var result = await _mediator.Send(command);

            return new OkObjectResult(new ResultResponse(result) { Message = string.Format(ResultResponse.ENTITY_INSERT_OK, result) });
        }

    }
}
