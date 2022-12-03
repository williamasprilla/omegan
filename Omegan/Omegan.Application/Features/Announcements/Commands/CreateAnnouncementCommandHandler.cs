using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Omegan.Application.Contracts.Persistence;
using Omegan.Application.Features.Announcements.Commands;
using Omegan.Domain;

namespace Omegan.Application.Features.Companies.Commands.CreateCompany
{

    public class CreateAnnouncementCommandHandler : IRequestHandler<CreateAnnouncementCommandMapper, int>
    {

        private readonly ILogger<CreateAnnouncementCommandHandler> _logger;
        private readonly IGenericRepository<Announcement, int> _announcementRepository;
        private readonly IMapper _mapper;

        public CreateAnnouncementCommandHandler(ILogger<CreateAnnouncementCommandHandler> logger, IGenericRepository<Announcement, int> announcementRepository, IMapper mapper)
        {
            _logger = logger;
            _announcementRepository = announcementRepository;
            _mapper = mapper;
        }


        public async Task<int> Handle(CreateAnnouncementCommandMapper request, CancellationToken cancellationToken)
        {

            var announcementEntity = _mapper.Map<Announcement>(request);

            var result = await _announcementRepository.AddAsync(announcementEntity,cancellationToken);

            if (result is null)
            {
                _logger.LogError("No se inserto el record del anuncio");
                throw new Exception("No se pudo insertar el record del anuncio");
            }

            return announcementEntity.Id;
        }
    }
}