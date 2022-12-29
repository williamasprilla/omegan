using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Omegan.Application.Contracts.Persistence;
using Omegan.Application.Exceptions;
using Omegan.Application.Features.Companies.Commands.UpdateCompany;
using Omegan.Application.Features.Countries.Commands.UpdateCountry;
using Omegan.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Products.Commands.UpdateProducts
{
    public class UpdateProductsCommandHandler : IRequestHandler<UpdateProductsCommandMapper>
    {
        private readonly ILogger<UpdateProductsCommandHandler> _logger;
        private readonly IGenericRepository<Product, int> _productsRepository;
        private readonly IMapper _mapper;

        public UpdateProductsCommandHandler(ILogger<UpdateProductsCommandHandler> logger, IGenericRepository<Product, int> cproductsRepository, IMapper mapper)
        {
            _logger = logger;
            _productsRepository = cproductsRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateProductsCommandMapper request, CancellationToken cancellationToken)
        {
            var productsToUpdate = await _productsRepository.GetByIdAsync(request.Id, cancellationToken);

            if (productsToUpdate == null)
            {
                _logger.LogError($"No se encontro el producto con el Id {request.Id}");
                throw new NotFoundException(nameof(Product), request.Id);
            }


            _mapper.Map(request, productsToUpdate, typeof(UpdateProductsCommandMapper), typeof(Country));

            await _productsRepository.UpdateAsync(productsToUpdate, cancellationToken);

            _logger.LogInformation($"Actualización exitosa para el Id {request.Id}");

            return Unit.Value;
        }
    }
}
