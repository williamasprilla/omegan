using MediatR;
using Microsoft.AspNetCore.Mvc;
using Omegan.Application.Features.Companies.Commands.CreateCompany;
using System.Net;
using System.Threading.Tasks;

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
        public async Task<ActionResult<int>> CreateCompany([FromBody] CreateCompanyCommandMapper command)
        {
            return await _mediator.Send(command);
        }
    }
}
