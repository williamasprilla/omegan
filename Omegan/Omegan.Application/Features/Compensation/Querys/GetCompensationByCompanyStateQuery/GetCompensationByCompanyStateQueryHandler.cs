using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Omegan.Application.Contracts.Persistence;
using Omegan.Application.Contracts.Specifications;
using Omegan.Application.Features.Announcements.Queries.GetAnnouncementByCompanyStateQuery;
using Omegan.Application.Features.Announcements.Queries.GetAnnouncementById;
using Omegan.Application.Features.Compensation.Querys.GetCompensationById;
using Omegan.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Compensation.Querys.GetCompensationByCompanyStateQuery
{
    public class GetCompensationByCompanyStateQueryHandler: IRequestHandler<GetCompensationByCompanyStateQuery, List<CompensationDTO>>
    {
        private readonly ILogger<GetCompensationByCompanyStateQueryHandler> _logger;
        private readonly IGenericRepository<Domain.Compensation, int> _compensationRepository;
        private readonly IMapper _mapper;

        public GetCompensationByCompanyStateQueryHandler(ILogger<GetCompensationByCompanyStateQueryHandler> logger, IGenericRepository<Domain.Compensation, int> compensationRepository, IMapper mapper)
        {
            _logger = logger;
            _compensationRepository = compensationRepository;
            _mapper = mapper;
        }

        public async Task<List<CompensationDTO>> Handle(GetCompensationByCompanyStateQuery request, CancellationToken cancellationToken)
        {
            var specification = new CompensationSpecificationByIdCompanyState(request.IdCompany, request.State);

            var compensation = await _compensationRepository.ListAsync(specification, cancellationToken);
            var result = _mapper.Map<List<CompensationDTO>>(compensation);
            return result;
        }
    }
}
