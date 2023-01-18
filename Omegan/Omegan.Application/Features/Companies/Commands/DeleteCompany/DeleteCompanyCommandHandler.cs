using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Omegan.Application.Contracts.Persistence;
using Omegan.Application.Exceptions;
using Omegan.Application.Features.Countries.Commands.DeleteCountry;
using Omegan.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Companies.Commands.DeleteCompany
{
    public class DeleteCompanyCommandHandler: IRequestHandler<DeleteCompanyCommandMapper, string>
    {
        private readonly ILogger<DeleteCompanyCommandHandler> _logger;
        private readonly IGenericRepository<Company, int> _companyRepository;
        private readonly IMapper _mapper;

        public DeleteCompanyCommandHandler(ILogger<DeleteCompanyCommandHandler> logger, IGenericRepository<Company, int> companyRepository, IMapper mapper)
        {
            _logger = logger;
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        public async Task<string> Handle(DeleteCompanyCommandMapper request, CancellationToken cancellationToken)
        {
            string userID = string.Empty;
            var companyToDelete = await _companyRepository.GetByIdAsync(request.Id, cancellationToken);

            userID = companyToDelete.UserId;

            if (companyToDelete == null)
            {
                _logger.LogError($"{request.Id} compañia no existe en el sistema ");
                throw new NotFoundException(nameof(Country), request.Id);
            }

            _mapper.Map(request, companyToDelete, typeof(DeleteCompanyCommandMapper), typeof(Company));

            await _companyRepository.DeleteAsync(companyToDelete, cancellationToken);


            _logger.LogInformation($"El {request.Id} fue eliminado con exito");

            return userID; 
        }
    }
}
