using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Omegan.Application.Contracts.Persistence;
using Omegan.Application.Exceptions;
using Omegan.Application.Features.Countries.Commands.CreateCountry;
using Omegan.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Countries.Commands.UpdateCountry
{
    public class UpdateCountryCommandHandler : IRequestHandler<UpdateCountryCommandMapper>
    {

        private readonly ILogger<UpdateCountryCommandHandler> _logger;
        private readonly IGenericRepository<Country, int> _countryRepository;
        private readonly IMapper _mapper;

        public UpdateCountryCommandHandler(ILogger<UpdateCountryCommandHandler> logger, IGenericRepository<Country, int> countryRepository, IMapper mapper)
        {
            _logger = logger;
            _countryRepository = countryRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateCountryCommandMapper request, CancellationToken cancellationToken)
        {
            var countryToUpdate = await _countryRepository.GetByIdAsync(request.Id, cancellationToken);

            if(countryToUpdate == null)
            {
                _logger.LogError($"No se encontro el pais con el Id {request.Id}"   );
                throw new NotFoundException(nameof(Country), request.Id);
            }


            _mapper.Map(request, countryToUpdate, typeof(UpdateCountryCommandMapper), typeof(Country));

            await _countryRepository.UpdateAsync(countryToUpdate, cancellationToken);

            _logger.LogInformation($"Actualizaión exitosa para el Id {request.Id}");

            return Unit.Value;
        }
    }
}
