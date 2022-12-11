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

namespace Omegan.Application.Features.Compensation.Querys
{
    public class GetAllCompanyCompensationQueryHandler : IRequestHandler<GetAllCompanyCompensationQuery, List<CompanyCompensationDTO>>
    {
        private readonly ILogger<GetAllCompanyCompensationQueryHandler> _logger;
        private readonly IGenericRepository<Omegan.Domain.Compensation, int> _compensationRepository;
        private readonly IMapper _mapper;

        public GetAllCompanyCompensationQueryHandler(ILogger<GetAllCompanyCompensationQueryHandler> logger, IGenericRepository<Domain.Compensation, int> compensationRepository, IMapper mapper)
        {
            _logger = logger;
            _compensationRepository = compensationRepository;
            _mapper = mapper;
        }

        public async Task<List<CompanyCompensationDTO>> Handle(GetAllCompanyCompensationQuery request, CancellationToken cancellationToken)
        {
            var specification = new CompensationSpecification();

            var compensation = await _compensationRepository.ListAsync(specification, cancellationToken);
            var result = _mapper.Map<List<CompanyCompensationDTO>>(compensation);
            return result;
        }
    }
}
