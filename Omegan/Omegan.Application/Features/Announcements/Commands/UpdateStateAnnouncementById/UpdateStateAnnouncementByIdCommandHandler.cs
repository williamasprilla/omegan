using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Omegan.Application.Contracts.Persistence;
using Omegan.Application.Exceptions;
using Omegan.Application.Features.Announcements.Commands.UpdateAnnouncement;
using Omegan.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Announcements.Commands.UpdateStateAnnouncementById
{
    public class UpdateStateAnnouncementByIdCommandHandler: IRequestHandler<UpdateStateAnnouncementByIdCommandMapper>
    {

        private readonly ILogger<UpdateStateAnnouncementByIdCommandHandler> _logger;
        private readonly IGenericRepository<Announcement, int> _announcementRepository;
        private readonly IMapper _mapper;

        public UpdateStateAnnouncementByIdCommandHandler(ILogger<UpdateStateAnnouncementByIdCommandHandler> logger, IGenericRepository<Announcement, int> announcementRepository, IMapper mapper)
        {
            _logger = logger;
            _announcementRepository = announcementRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateStateAnnouncementByIdCommandMapper request, CancellationToken cancellationToken)
        {
            var announcementToUpdate = await _announcementRepository.GetByIdAsync(request.Id, cancellationToken);

            if (announcementToUpdate == null)
            {
                _logger.LogError($"No se encontro el anuncio con el Id {request.Id}");
                throw new NotFoundException(nameof(Announcement), request.Id);
            }


            announcementToUpdate.State = request.State;

            await _announcementRepository.UpdateAsync(announcementToUpdate, cancellationToken);

            _logger.LogInformation($"Actualizaión exitosa para el Id {request.Id}");

            return Unit.Value;
        }
    }
}
