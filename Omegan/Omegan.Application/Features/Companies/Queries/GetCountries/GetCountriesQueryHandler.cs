using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Omegan.Application.Contracts.Persistence;
using Omegan.Application.Contracts.Specifications;
using Omegan.Application.Features.Companies.Queries.GetCompanyByUserId;
using Omegan.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Companies.Queries.GetCountries
{
    public class GetCountriesQueryHandler: IRequestHandler<GetCountriesQuery, GetCountriesDTO>
    {
        private readonly ILogger<GetCountriesQueryHandler> _logger;
        private readonly IGenericRepository<Country, int> _countryRepository;
        private readonly IMapper _mapper;

        public GetCountriesQueryHandler(ILogger<GetCountriesQueryHandler> logger, IGenericRepository<Country, int> countryRepository, IMapper mapper)
        {
            _logger = logger;
            _countryRepository = countryRepository;
            _mapper = mapper;
        }

        public async Task<GetCountriesDTO> Handle(GetCountriesQuery request, CancellationToken cancellationToken)
        {
            var specification = new CountrySpecification(request.CountryId);

            var country = await _countryRepository.FirstAsync(specification, cancellationToken);

            var result = _mapper.Map<GetCountriesDTO>(country);

            return result;
        }
    }
}
