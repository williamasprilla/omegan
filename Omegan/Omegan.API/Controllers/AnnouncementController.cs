using MediatR;
using Microsoft.AspNetCore.Mvc;
using Omegan.Application.Features.Announcements.Commands;
using Omegan.Application.Features.Announcements.Commands.UpdateAnnouncement;
using Omegan.Application.Features.Announcements.Queries.GetAnnouncementByCompany;
using Omegan.Application.Features.Announcements.Queries.GetAnnouncementByCompanyStateQuery;
using Omegan.Application.Features.Announcements.Queries.GetAnnouncementsById;
using Omegan.Application.Features.Companies.Commands.UpdateCompany;
using Omegan.Application.Features.Companies.Queries.GetCompanyById;
using Omegan.Application.Utils;
using System.Net;

namespace Omegan.API.Controllers
{
    public class AnnouncementController : ApiControllerBase
    {

        private IMediator _mediator;


        public AnnouncementController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [ProducesResponseType((int)HttpStatusCode.OK)]
        [HttpPost("RegisterAnnouncement")]
        public async Task<IActionResult> CreateCompany([FromBody] CreateAnnouncementCommandMapper command)
        {

            var result = await _mediator.Send(command);

            return new OkObjectResult(new ResultResponse(result) { Message = string.Format(ResultResponse.ENTITY_INSERT_OK, result) });
        }


        [HttpPut("UpdateAnnouncement")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateAnnouncement([FromBody] UpdateAnnouncementCommandMapper command)
        {
            var result = await _mediator.Send(command);
            return new OkObjectResult(new ResultResponse(result) { Message = string.Format(ResultResponse.ENTITY_INSERT_OK, result) });
        }




        [HttpGet("GetAnnouncementsById")]
        public async Task<IActionResult> GetAnnouncementsById(int id)
        {
            var query = new GetAnnouncementByIdQuery(id);
            var announcement = await _mediator.Send(query);
            return new OkObjectResult(new ResultResponse(announcement) { Message = string.Format(ResultResponse.ENTITY_GET, announcement) });
        }


        [HttpGet("GetAnnouncementsByCompany")]
        public async Task<IActionResult> GetAnnouncementsByCompany(int idCompany)
        {
            var query = new GetAnnouncementByCompanyQuery(idCompany);
            var announcement = await _mediator.Send(query);
            return new OkObjectResult(new ResultResponse(announcement) { Message = string.Format(ResultResponse.ENTITY_GET, announcement) });
        }


        [HttpGet("GetAnnouncementsByCompanyState")]
        public async Task<IActionResult> GetAnnouncementsByCompanyState(int idCompany, int State)
        {
            var query = new GetAnnouncementByCompanyStateQuery(idCompany,State);
            var announcement = await _mediator.Send(query);
            return new OkObjectResult(new ResultResponse(announcement) { Message = string.Format(ResultResponse.ENTITY_GET, announcement) });
        }

    }
}
