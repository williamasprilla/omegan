using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Omegan.Application.Features.Archives.Commands.CreateArchive;
using Omegan.Application.Features.Companies.Commands.CreateCompany;
using Omegan.Application.Features.Companies.Queries.GetAllCompanyAnnouncements;
using Omegan.Application.Features.Companies.Queries.GetCompanyByIdWithArchives;
using Omegan.Application.Features.Companies.Queries.GetCompanyByUserId;
using Omegan.Application.Features.Countries.Commands.CreateCountry;
using Omegan.Application.Utils;
using Omegan.Domain;
using System.Net;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Omegan.API.Controllers
{
    public class ArchivesController : ApiControllerBase
    {
        private IMediator _mediator;

        public ArchivesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetArchivesByCompany")]
        public async Task<IActionResult> GetArchivesByCompany(int companyId)
        {
            var query = new GetArchivesByCompanyQuery(companyId);
            var archive = await _mediator.Send(query);
            return new OkObjectResult(new ResultResponse(archive) { Message = string.Format(ResultResponse.ENTITY_GET, archive) });
        }


        [ProducesResponseType((int)HttpStatusCode.OK)]
        [HttpPost("CreateArchive")]
        public async Task<IActionResult> CreateArchive([FromBody] CreateArchiveCommandMapper command)
        {
            var result = await _mediator.Send(command);

            return new OkObjectResult(new ResultResponse(result) { Message = string.Format(ResultResponse.ENTITY_INSERT_OK, result) });
        }


    }
}


