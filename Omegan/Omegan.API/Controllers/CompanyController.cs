using MediatR;
using Microsoft.AspNetCore.Mvc;
using Omegan.Application.Contracts.Identity;
using Omegan.Application.Features.Archives.Commands.DeleteArchives;
using Omegan.Application.Features.Companies.Commands.CreateCompany;
using Omegan.Application.Features.Companies.Commands.DeleteCompany;
using Omegan.Application.Features.Companies.Commands.UpdateCompany;
using Omegan.Application.Features.Companies.Queries.GetAllCompanyAnnouncements;
using Omegan.Application.Features.Companies.Queries.GetCompanyById;
using Omegan.Application.Features.Companies.Queries.GetCompanyByIdWithArchives;
using Omegan.Application.Features.Companies.Queries.GetCompanyByUserId;
using Omegan.Application.Features.Countries.Commands.DeleteCountry;
using Omegan.Application.Features.Countries.Commands.UpdateCountry;
using Omegan.Application.Models.Identity;
using Omegan.Application.Utils;
using System.Net;

namespace Omegan.API.Controllers
{
    public class CompanyController : ApiControllerBase
    {

        private IMediator _mediator;
        private readonly IAuthService _authService;


        public CompanyController(IMediator mediator, IAuthService authService)
        {
            _mediator = mediator;
            _authService = authService;
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
        public async Task<IActionResult> GetAllCompanyAnnouncements(int state)
        {
            var query = new GetAllCompanyAnnouncementsQuery(state);
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


        [HttpDelete("{id}", Name = "DeleteCompany")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            var command = new DeleteCompanyCommandMapper
            {
                Id = id
            };
            //
            var commandArchives = new DeleteArchivesCommandMapper
            {
                CompanyId = id
            };

            var resultArchives = await _mediator.Send(commandArchives);

            var resultCompany = await _mediator.Send(command);

            //
            var commandDel = new DeleteUserRequest
            {
                UserId = resultCompany
            };

            //Elimina usuario de tabla aspnet user
            var result = await _authService.DeleteUser(commandDel);

            return new OkObjectResult(new ResultResponse(resultArchives) { Message = string.Format(ResultResponse.ENTITY_INSERT_OK, resultArchives) });
        }


    }
}
