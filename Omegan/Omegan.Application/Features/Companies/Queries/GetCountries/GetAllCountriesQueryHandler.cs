using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Omegan.Application.Contracts.Persistence;
using Omegan.Application.Contracts.Specifications;
using Omegan.Application.Features.Companies.Queries.GetAllCompanyAnnouncements;
using Omegan.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Companies.Queries.GetCountries
{
    public class GetAllCountriesQueryHandler: IRequestHandler<GetAllCountriesQuery, List<GetCountriesDTO>>
    {
        private readonly ILogger<GetCountriesQueryHandler> _logger;
        private readonly IGenericRepository<Country, int> _countryRepository;
        private readonly IMapper _mapper;

        public GetAllCountriesQueryHandler(ILogger<GetCountriesQueryHandler> logger, IGenericRepository<Country, int> countryRepository, IMapper mapper)
        {
            _logger = logger;
            _countryRepository = countryRepository;
            _mapper = mapper;
        }


        public async Task<List<GetCountriesDTO>> Handle(GetAllCountriesQuery request, CancellationToken cancellationToken)
        {
            var specification = new CountrySpecification();

            var country = await _countryRepository.ListAsync(specification, cancellationToken);
            var result = _mapper.Map<List<GetCountriesDTO>>(country);
            return result;
        }


    }
}
