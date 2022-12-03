using MediatR;
using Microsoft.AspNetCore.Mvc;
using Omegan.Application.Features.Announcements.Commands;
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
       
    }
}
