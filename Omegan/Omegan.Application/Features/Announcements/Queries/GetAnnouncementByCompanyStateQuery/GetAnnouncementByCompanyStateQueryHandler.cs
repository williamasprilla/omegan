using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Omegan.Application.Contracts.Persistence;
using Omegan.Application.Contracts.Specifications;
using Omegan.Application.Features.Announcements.Queries.GetAnnouncementByCompany;
using Omegan.Application.Features.Announcements.Queries.GetAnnouncementById;
using Omegan.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Announcements.Queries.GetAnnouncementByCompanyStateQuery
{
    public class GetAnnouncementByCompanyStateQueryHandler : IRequestHandler<GetAnnouncementByCompanyStateQuery, List<AnnouncementDTO>>
    {

        private readonly ILogger<GetAnnouncementByCompanyStateQueryHandler> _logger;
        private readonly IGenericRepository<Announcement, int> _announcementRepository;
        private readonly IMapper _mapper;

        public GetAnnouncementByCompanyStateQueryHandler(ILogger<GetAnnouncementByCompanyStateQueryHandler> logger, IGenericRepository<Announcement, int> announcementRepository, IMapper mapper)
        {
            _logger = logger;
            _announcementRepository = announcementRepository;
            _mapper = mapper;
        }

        public async Task<List<AnnouncementDTO>> Handle(GetAnnouncementByCompanyStateQuery request, CancellationToken cancellationToken)
        {
            var specification = new AnnouncementSpecificationByIdCompanyState(request.IdCompany, request.State);

            var announcement = await _announcementRepository.ListAsync(specification, cancellationToken);
            var result = _mapper.Map<List<AnnouncementDTO>>(announcement);
            return result;
        }
    }
}
