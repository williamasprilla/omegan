using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Omegan.Application.Features.Announcements.Queries.GetAnnouncementByCompany;
using Omegan.Application.Features.Announcements.Queries.GetAnnouncementsById;
using Omegan.Application.Features.Companies.Queries.GetCountries;
using Omegan.Application.Features.TRM.Queries;
using Omegan.Application.Utils;
using Omegan.Domain;

namespace Omegan.API.Controllers
{
   
    public class CalculateController : ApiControllerBase
    {
        private IMediator _mediator;

        public CalculateController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet("GetValuesTRM")]
        public async Task<IActionResult> GetValuesTRM()
        {
            double Round1;
            int IdCompany = 1;
            //Datos Tabla TRM para calculos
            var querytrm = new GetTRMListQuery();
            var trm = await _mediator.Send(querytrm);

            //Datos del pais
            var querycountry = new GetAllCountriesQuery();
            var country = await _mediator.Send(querycountry);

            foreach(var data in country)
            {
                var query = new GetAnnouncementByCompanyQuery(IdCompany);
                var announcement = await _mediator.Send(query);

                //Round1 = (trm.First().TRMValue * )
            }

            return new OkObjectResult(new ResultResponse(trm) { Message = string.Format(ResultResponse.ENTITY_GET, trm) });
        }

        

    }
}
