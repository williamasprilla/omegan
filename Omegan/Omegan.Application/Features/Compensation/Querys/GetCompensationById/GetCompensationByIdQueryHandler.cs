using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Omegan.Application.Contracts.Persistence;
using Omegan.Application.Contracts.Specifications;
using Omegan.Application.Features.Announcements.Queries.GetAnnouncementById;
using Omegan.Application.Features.Announcements.Queries.GetAnnouncementsById;
using Omegan.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Compensation.Querys.GetCompensationById
{
    public class GetCompensationByIdQueryHandler: IRequestHandler<GetCompensationByIdQuery, CompensationDTO>
    {

        private readonly ILogger<GetCompensationByIdQueryHandler> _logger;
        private readonly IGenericRepository<Omegan.Domain.Compensation, int> _compensationRepository;
        private readonly IMapper _mapper;

        public GetCompensationByIdQueryHandler(ILogger<GetCompensationByIdQueryHandler> logger, IGenericRepository<Domain.Compensation, int> compensationRepository, IMapper mapper)
        {
            _logger = logger;
            _compensationRepository = compensationRepository;
            _mapper = mapper;
        }

        public async Task<CompensationDTO> Handle(GetCompensationByIdQuery request, CancellationToken cancellationToken)
        {
            var specification = new CompensationSpecificationId(request.Id);

            var compensation = await _compensationRepository.FirstAsync(specification, cancellationToken);
            var result = _mapper.Map<CompensationDTO>(compensation);
            return result;
        }
    }
}
