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

namespace Omegan.Application.Features.Compensation.Commands.UpdateCompensation
{
    public class UpdateCompensationCommandHandler: IRequestHandler<UpdateCompensationCommandMapper>
    {
        private readonly ILogger<UpdateCompensationCommandHandler> _logger;
        private readonly IGenericRepository<Omegan.Domain.Compensation, int> _compensationRepository;
        private readonly IMapper _mapper;

        public UpdateCompensationCommandHandler(ILogger<UpdateCompensationCommandHandler> logger, IGenericRepository<Omegan.Domain.Compensation, int> compensationRepository, IMapper mapper)
        {
            _logger = logger;
            _compensationRepository = compensationRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateCompensationCommandMapper request, CancellationToken cancellationToken)
        {
            var compensationToUpdate = await _compensationRepository.GetByIdAsync(request.Id, cancellationToken);

            if (compensationToUpdate == null)
            {
                _logger.LogError($"No se encontro la solicitud de compensaciòn con el Id {request.Id}");
                throw new NotFoundException(nameof(Omegan.Domain.Compensation), request.Id);
            }


            _mapper.Map(request, compensationToUpdate, typeof(UpdateCompensationCommandMapper), typeof(Omegan.Domain.Compensation));

            await _compensationRepository.UpdateAsync(compensationToUpdate, cancellationToken);

            _logger.LogInformation($"Actualizaión exitosa para el Id {request.Id}");

            return Unit.Value;
        }
    }
}
