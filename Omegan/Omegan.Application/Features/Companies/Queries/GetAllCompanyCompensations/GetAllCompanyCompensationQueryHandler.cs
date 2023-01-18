using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Omegan.Application.Contracts.Persistence;
using Omegan.Application.Contracts.Specifications;
using Omegan.Application.Features.Companies.Queries.GetAllCompanyAnnouncements;
using Omegan.Application.Features.Companies.Queries.GetAllCompanyCompensationsQuery;
using Omegan.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Companies.Queries.GetAllCompanyCompensations
{
    public class GetAllCompanyCompensationQueryHandler: IRequestHandler<GetAllCompanyCompensationQuery, List<CompanyCompensationsDTO>>
    {

        private readonly ILogger<GetAllCompanyCompensationQueryHandler> _logger;
        private readonly IGenericRepository<Company, int> _companyRepository;
        private readonly IMapper _mapper;

        public GetAllCompanyCompensationQueryHandler(ILogger<GetAllCompanyCompensationQueryHandler> logger, IGenericRepository<Company, int> companyRepository, IMapper mapper)
        {
            _logger = logger;
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        public async Task<List<CompanyCompensationsDTO>> Handle(GetAllCompanyCompensationQuery request, CancellationToken cancellationToken)
        {
            var specification = new CompanySpecificationState(request.State);

            var company = await _companyRepository.ListAsync(specification, cancellationToken);
            var result = _mapper.Map<List<CompanyCompensationsDTO>>(company);
            return result;
        }
    }
}
