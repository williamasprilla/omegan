using MediatR;
using Microsoft.AspNetCore.Mvc;
using Omegan.Application.Features.Companies.Commands.CreateCompany;
using Omegan.Application.Features.Companies.Commands.UpdateCompany;
using Omegan.Application.Features.Companies.Queries.GetAllCompanyAnnouncements;
using Omegan.Application.Features.Companies.Queries.GetCompanyById;
using Omegan.Application.Features.Companies.Queries.GetCompanyByIdWithArchives;
using Omegan.Application.Features.Companies.Queries.GetCompanyByUserId;
using Omegan.Application.Features.Countries.Commands.UpdateCountry;
using Omegan.Application.Utils;
using System.Net;

namespace Omegan.API.Controllers
{
    public class CompanyController : ApiControllerBase
    {

        private IMediator _mediator;


        public CompanyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [ProducesResponseType((int)HttpStatusCode.OK)]
        [HttpPost("RegisterCompany")]
        public async Task<IActionResult> CreateCompany([FromBody] CreateCompanyCommandMapper command)
        {
            var result =  await _mediator.Send(command);
            return new OkObjectResult(new ResultResponse(result) { Message = string.Format(ResultResponse.ENTITY_INSERT_OK, result) });
        }


        [HttpGet("{userid}", Name = "GetCompany")]
        public async Task<IActionResult> GetCompanyByUserId(string userid)
        {
            var query = new GetCompanyByUserIdQuery(userid);
            var company = await _mediator.Send(query);
            return new OkObjectResult(new ResultResponse(company) { Message = string.Format(ResultResponse.ENTITY_GET, company) });
        }



        [HttpGet("GetAllCompanyAnnouncements")]
        public async Task<IActionResult> GetAllCompanyAnnouncements()
        {
            var query = new GetAllCompanyAnnouncementsQuery();
            var company = await _mediator.Send(query);
            return new OkObjectResult(new ResultResponse(company) { Message = string.Format(ResultResponse.ENTITY_GET, company) });
        }


        [HttpGet("GetCompanyById")]
        public async Task<IActionResult> GetCompanyById(int id)
        {
            var query = new GetCompanyByIdQuery(id);
            var company = await _mediator.Send(query);
            return new OkObjectResult(new ResultResponse(company) { Message = string.Format(ResultResponse.ENTITY_GET, company) });
        }

        [HttpPut("UpdateState")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateState([FromBody] UpdateCompanyCommandMapper command)
        {
            var result = await _mediator.Send(command);
            return new OkObjectResult(new ResultResponse(result) { Message = string.Format(ResultResponse.ENTITY_INSERT_OK, result) });
        }


        

    }
}
