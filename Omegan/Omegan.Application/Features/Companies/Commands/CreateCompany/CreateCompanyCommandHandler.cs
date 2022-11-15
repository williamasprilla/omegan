using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Omegan.Application.Contracts.Persistence;
using Omegan.Domain;

namespace Omegan.Application.Features.Companies.Commands.CreateCompany
{
    internal class CreateCompanyCommandHandler
    {
    }

    public class CreateDirectorCommandHandler : IRequestHandler<CreateCompanyCommandMapper, int>
    {
        private readonly ILogger<CreateDirectorCommandHandler> _logger;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public CreateDirectorCommandHandler(ILogger<CreateDirectorCommandHandler> logger, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Handle(CreateCompanyCommandMapper request, CancellationToken cancellationToken)
        {

                var directorEntity = _mapper.Map<Company>(request);

                _unitOfWork.Repository<Company>().AddEntity(directorEntity);

                var result = await _unitOfWork.Complete();

                if (result <= 0)
                {
                    _logger.LogError("No se inserto el record del director");
                    throw new Exception("No se pudo insertar el record del director");
                }

                return directorEntity.Id;
        }
    }
}
