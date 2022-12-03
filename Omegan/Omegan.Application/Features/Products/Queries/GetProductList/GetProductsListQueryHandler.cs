using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Omegan.Application.Contracts.Persistence;
using Omegan.Domain;

namespace Omegan.Application.Features.Products.Queries.GetProductList
{
    public class GetProductsListQueryHandler : IRequestHandler<GetProductsListQuery, List<ProductoDTO>>
    {

        private readonly IGenericRepository<Product, int> _productRepository;
        private readonly IMapper _mapper;

        public GetProductsListQueryHandler(ILogger<GetProductsListQuery> logger, IGenericRepository<Product, int> productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductoDTO>> Handle(GetProductsListQuery request, CancellationToken cancellationToken)
        {
            var productsList = await _productRepository.ListAllAsync();

            return _mapper.Map<List<ProductoDTO>>(productsList);
        }
    }
}
