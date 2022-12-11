using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Omegan.Application.Contracts.Persistence;
using Omegan.Application.Contracts.Specifications;
using Omegan.Application.DTOs;
using Omegan.Application.Features.Announcements.Queries.GetAnnouncementsById;
using Omegan.Application.Features.Companies.Queries.GetAllCompanyAnnouncements;
using Omegan.Application.Features.Companies.Queries.GetCompanyById;
using Omegan.Application.Features.Companies.Queries.GetCompanyByUserId;
using Omegan.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Announcements.Queries.GetAnnouncementById
{
    public class GetAnnouncementByIdQueryHandler: IRequestHandler<GetAnnouncementByIdQuery, AnnouncementDTO>
    {
        private readonly ILogger<GetAnnouncementByIdQueryHandler> _logger;
        private readonly IGenericRepository<Announcement, int> _announcementRepository;
        private readonly IMapper _mapper;

        public GetAnnouncementByIdQueryHandler(ILogger<GetAnnouncementByIdQueryHandler> logger, IGenericRepository<Announcement, int> announcementRepository, IMapper mapper)
        {
            _logger = logger;
            _announcementRepository = announcementRepository;
            _mapper = mapper;
        }

        public async Task<AnnouncementDTO> Handle(GetAnnouncementByIdQuery request, CancellationToken cancellationToken)
        {
            var specification = new AnnouncementSpecification(request.Id);

            //var announcement = await _announcementRepository.ListAsync(specification, cancellationToken);
            //var result = _mapper.Map<AnnouncementDTO>(announcement);
            //return result;


            var announcement = await _announcementRepository.FirstAsync(specification, cancellationToken);
            var result = _mapper.Map<AnnouncementDTO>(announcement);
            return result;
        }
    }
}
