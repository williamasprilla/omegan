using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Omegan.Application.Contracts.Persistence;
using Omegan.Domain;

namespace Omegan.Application.Features.Companies.Commands.CreateCompany
{
   
    public class CreateCompanyCommandHandler : IRequestHandler<CreateCompanyCommandMapper, int>
    {
        private readonly ILogger<CreateCompanyCommandHandler> _logger;
        private readonly IGenericRepository<Company, int> _companyRepository;
        private readonly IMapper _mapper;

        public CreateCompanyCommandHandler(ILogger<CreateCompanyCommandHandler> logger, IGenericRepository<Company, int> companyRepository, IMapper mapper)
        {
            _logger = logger;
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateCompanyCommandMapper request, CancellationToken cancellationToken)
        {

                var companyEntity = _mapper.Map<Company>(request);

                var result = await _companyRepository.AddAsync(companyEntity, cancellationToken); 

                if (result is null)
                {
                    _logger.LogError("No se inserto el record de la empresa");
                    throw new Exception("No se pudo insertar el record de la empresa");
                }

                return companyEntity.Id;
        }
    }
}
