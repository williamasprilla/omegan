using MediatR;
using Microsoft.AspNetCore.Mvc;
using Omegan.Application.Features.Companies.Commands.CreateCompany;
using Omegan.Application.Features.Companies.Commands.UpdateCompany;
using Omegan.Application.Features.Products.Commands.CreateProduct;
using Omegan.Application.Features.Products.Commands.UpdateProducts;
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
        
        
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [HttpPost("RegisterProducts")]
        public async Task<IActionResult> CreateProducts([FromBody] CreateProductsCommandMapper command)
        {
            var result = await _mediator.Send(command);
            return new OkObjectResult(new ResultResponse(result) { Message = string.Format(ResultResponse.ENTITY_INSERT_OK, result) });
        }


        [HttpPut("UpdateProducts")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateProducts([FromBody] UpdateProductsCommandMapper command)
        {
            var result = await _mediator.Send(command);
            return new OkObjectResult(new ResultResponse(result) { Message = string.Format(ResultResponse.ENTITY_INSERT_OK, result) });
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
