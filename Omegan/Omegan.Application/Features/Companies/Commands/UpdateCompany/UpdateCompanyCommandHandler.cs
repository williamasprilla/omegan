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

namespace Omegan.Application.Features.Companies.Commands.UpdateCompany
{
    public class UpdateCompanyCommandHandler : IRequestHandler<UpdateCompanyCommandMapper>
    {

        private readonly ILogger<UpdateCompanyCommandHandler> _logger;
        private readonly IGenericRepository<Company, int> _companyRepository;
        private readonly IMapper _mapper;

        public UpdateCompanyCommandHandler(ILogger<UpdateCompanyCommandHandler> logger, IGenericRepository<Company, int> companyRepository, IMapper mapper)
        {
            _logger = logger;
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateCompanyCommandMapper request, CancellationToken cancellationToken)
        {
            var companyToUpdate = await _companyRepository.GetByIdAsync(request.Id, cancellationToken);

            if (companyToUpdate == null)
            {
                _logger.LogError($"No se encontro la compañia con el Id {request.Id}");
                throw new NotFoundException(nameof(Company), request.Id);
            }


            _mapper.Map(request, companyToUpdate, typeof(UpdateCountryCommandMapper), typeof(Country));

            await _companyRepository.UpdateAsync(companyToUpdate, cancellationToken);

            _logger.LogInformation($"Actualizaión exitosa para el Id {request.Id}");

            return Unit.Value;
        }
    }
}
