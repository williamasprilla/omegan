using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Omegan.Application.Contracts.Persistence;
using Omegan.Application.Exceptions;
using Omegan.Application.Features.Companies.Commands.UpdateCompany;
using Omegan.Application.Features.Countries.Commands.UpdateCountry;
using Omegan.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Announcements.Commands.UpdateAnnouncement
{
    public class UpdateAnnouncementCommandHandler: IRequestHandler<UpdateAnnouncementCommandMapper>
    {

        private readonly ILogger<UpdateAnnouncementCommandHandler> _logger;
        private readonly IGenericRepository<Announcement, int> _announcementRepository;
        private readonly IMapper _mapper;

        public UpdateAnnouncementCommandHandler(ILogger<UpdateAnnouncementCommandHandler> logger, IGenericRepository<Announcement, int> announcementRepository, IMapper mapper)
        {
            _logger = logger;
            _announcementRepository = announcementRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateAnnouncementCommandMapper request, CancellationToken cancellationToken)
        {
            var announcementToUpdate = await _announcementRepository.GetByIdAsync(request.Id, cancellationToken);

            if (announcementToUpdate == null)
            {
                _logger.LogError($"No se encontro el anuncio con el Id {request.Id}");
                throw new NotFoundException(nameof(Company), request.Id);
            }


            _mapper.Map(request, announcementToUpdate, typeof(UpdateAnnouncementCommandMapper), typeof(Announcement));

            await _announcementRepository.UpdateAsync(announcementToUpdate, cancellationToken);

            _logger.LogInformation($"Actualizaión exitosa para el Id {request.Id}");

            return Unit.Value;
        }
    }
}
