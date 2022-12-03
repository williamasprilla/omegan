using MediatR;

namespace Omegan.Application.Features.Products.Queries.GetProductList
{
    public class GetProductsListQuery : IRequest <List<ProductoDTO>>
    {
    }
}
