using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Omegan.Application.Contracts.Persistence;
using Omegan.Application.Features.Companies.Commands.CreateCompany;
using Omegan.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Countries.Commands.CreateCountry
{
    public class CreateCountryCommandHandler: IRequestHandler<CreateCountryCommandMapper, int>
    {
        private readonly ILogger<CreateCountryCommandHandler> _logger;
        private readonly IGenericRepository<Country, int> _countryRepository;
        private readonly IMapper _mapper;

        public CreateCountryCommandHandler(ILogger<CreateCountryCommandHandler> logger, IGenericRepository<Country, int> countryRepository, IMapper mapper)
        {
            _logger = logger;
            _countryRepository = countryRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateCountryCommandMapper request, CancellationToken cancellationToken)
        {

            var countryEntity = _mapper.Map<Country>(request);

            var result = await _countryRepository.AddAsync(countryEntity, cancellationToken);

            if (result is null)
            {
                _logger.LogError("No se inserto el record del pais");
                throw new Exception("No se pudo insertar el record del pais");
            }

            return countryEntity.Id;
        }



    }
}
