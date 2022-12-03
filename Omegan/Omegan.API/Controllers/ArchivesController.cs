using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Omegan.Application.Features.Companies.Commands.CreateCompany;
using Omegan.Application.Features.Companies.Queries.GetAllCompanyAnnouncements;
using Omegan.Application.Features.Companies.Queries.GetCompanyByIdWithArchives;
using Omegan.Application.Features.Companies.Queries.GetCompanyByUserId;
using Omegan.Application.Utils;
using Omegan.Domain;
using System.Net;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Omegan.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArchivesController : ApiControllerBase
    {
        private IMediator _mediator;

        public ArchivesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetArchivesByCompany")]
        public async Task<IActionResult> GetArchivesByCompany(int userid)
        {
            var query = new GetArchivesByCompanyQuery(userid);
            var archive = await _mediator.Send(query);
            return new OkObjectResult(new ResultResponse(archive) { Message = string.Format(ResultResponse.ENTITY_GET, archive) });
        }

    }
}


