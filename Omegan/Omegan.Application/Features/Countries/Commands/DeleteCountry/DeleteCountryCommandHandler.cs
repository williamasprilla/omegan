using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Omegan.Application.Contracts.Persistence;
using Omegan.Application.Exceptions;
using Omegan.Application.Features.Countries.Commands.CreateCountry;
using Omegan.Application.Features.Countries.Commands.UpdateCountry;
using Omegan.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Countries.Commands.DeleteCountry
{
    public class DeleteCountryCommandHandler: IRequestHandler<DeleteCountryCommandMapper>
    {
        private readonly ILogger<DeleteCountryCommandHandler> _logger;
        private readonly IGenericRepository<Country, int> _countryRepository;
        private readonly IMapper _mapper;

        public DeleteCountryCommandHandler(ILogger<DeleteCountryCommandHandler> logger, IGenericRepository<Country, int> countryRepository, IMapper mapper)
        {
            _logger = logger;
            _countryRepository = countryRepository;
            _mapper = mapper;
        }



        public async Task<Unit> Handle(DeleteCountryCommandMapper request, CancellationToken cancellationToken)
        {
            var countryToDelete = await _countryRepository.GetByIdAsync(request.Id, cancellationToken);

            if (countryToDelete == null)
            {
                _logger.LogError($"{request.Id} pais no existe en el sistema ");
                throw new NotFoundException(nameof(Country), request.Id);
            }


            _mapper.Map(request, countryToDelete, typeof(DeleteCountryCommandMapper), typeof(Country));

            await _countryRepository.DeleteAsync(countryToDelete, cancellationToken);

            _logger.LogInformation($"El {request.Id} fue eliminado con exito");

            return Unit.Value;
        }



    }
}
