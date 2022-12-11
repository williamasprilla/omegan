using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Omegan.Application.Contracts.Persistence;
using Omegan.Application.Exceptions;
using Omegan.Application.Features.Countries.Commands.UpdateCountry;
using Omegan.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.TRM.Commands.UpdateTRM
{
    public class UpdateTRMCommandHandler: IRequestHandler<UpdateTRMCommandMapper>
    {
        private readonly ILogger<UpdateTRMCommandHandler> _logger;
        private readonly IGenericRepository<Trm, int> _trmRepository;
        private readonly IMapper _mapper;

        public UpdateTRMCommandHandler(ILogger<UpdateTRMCommandHandler> logger, IGenericRepository<Trm, int> trmRepository, IMapper mapper)
        {
            _logger = logger;
            _trmRepository = trmRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateTRMCommandMapper request, CancellationToken cancellationToken)
        {
            var trmToUpdate = await _trmRepository.GetByIdAsync(request.Id, cancellationToken);

            if (trmToUpdate == null)
            {
                _logger.LogError($"No se encontro el pais con el Id {request.Id}");
                throw new NotFoundException(nameof(Country), request.Id);
            }

            _mapper.Map(request, trmToUpdate, typeof(UpdateTRMCommandMapper), typeof(Trm));
            await _trmRepository.UpdateAsync(trmToUpdate, cancellationToken);
            _logger.LogInformation($"Actualizaión exitosa para el Id {request.Id}");

            return Unit.Value;
        }
    }
}
