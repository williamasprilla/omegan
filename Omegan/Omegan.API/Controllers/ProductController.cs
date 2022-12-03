using MediatR;
using Microsoft.AspNetCore.Mvc;
using Omegan.Application.Features.Companies.Commands.CreateCompany;
using Omegan.Application.Features.Products.Queries.GetProductList;
using Omegan.Application.Utils;
using System.Net;

namespace Omegan.API.Controllers
{
    public class ProductController : ApiControllerBase
    {

        private IMediator _mediator;


        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetProducts")]
        public async Task<IActionResult> GetProducts()
        {
            var query = new GetProductsListQuery();

            var products = await _mediator.Send(query);

            return new OkObjectResult(new ResultResponse(products) { Message = string.Format(ResultResponse.ENTITY_GET, products) });
        }
    }
}
