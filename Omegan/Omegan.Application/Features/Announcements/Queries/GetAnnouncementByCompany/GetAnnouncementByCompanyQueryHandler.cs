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

namespace Omegan.Application.Features.Announcements.Queries.GetAnnouncementByCompany
{
    public class GetAnnouncementByCompanyQueryHandler: IRequestHandler<GetAnnouncementByCompanyQuery, AnnouncementDTO>
    {

        private readonly ILogger<GetAnnouncementByCompanyQueryHandler> _logger;
        private readonly IGenericRepository<Announcement, int> _announcementRepository;
        private readonly IMapper _mapper;

        public GetAnnouncementByCompanyQueryHandler(ILogger<GetAnnouncementByCompanyQueryHandler> logger, IGenericRepository<Announcement, int> announcementRepository, IMapper mapper)
        {
            _logger = logger;
            _announcementRepository = announcementRepository;
            _mapper = mapper;
        }

        public async Task<AnnouncementDTO> Handle(GetAnnouncementByCompanyQuery request, CancellationToken cancellationToken)
        {
            var specification = new AnnouncementSpecificationByIdCompany(request.IdCompany);

            var announcement = await _announcementRepository.FirstAsync(specification, cancellationToken);
            var result = _mapper.Map<AnnouncementDTO>(announcement);
            return result;
        }
    }
}
