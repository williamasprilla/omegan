using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Omegan.Application.Contracts.Persistence;
using Omegan.Application.Features.Companies.Commands.CreateCompany;
using Omegan.Application.Features.Products.Commands.CreateProduct;
using Omegan.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Products.Commands.CreateProducts
{
    public class CreateProductsCommandHandler:IRequestHandler<CreateProductsCommandMapper, int>
    {
        private readonly ILogger<CreateProductsCommandHandler> _logger;
        private readonly IGenericRepository<Product, int> _productsRepository;
        private readonly IMapper _mapper;

        public CreateProductsCommandHandler(ILogger<CreateProductsCommandHandler> logger, IGenericRepository<Product, int> productsRepository, IMapper mapper)
        {
            _logger = logger;
            _productsRepository = productsRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateProductsCommandMapper request, CancellationToken cancellationToken)
        {
            var productsEntity = _mapper.Map<Product>(request);

            var result = await _productsRepository.AddAsync(productsEntity, cancellationToken);

            if (result is null)
            {
                _logger.LogError("No se inserto el record del producto");
                throw new Exception("No se pudo insertar el record del producto");
            }

            return productsEntity.Id;
        }
    }
}
