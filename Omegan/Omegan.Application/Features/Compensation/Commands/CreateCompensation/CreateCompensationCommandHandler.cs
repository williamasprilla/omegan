using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Omegan.Application.Contracts.Persistence;
using Omegan.Application.Features.Companies.Commands.CreateCompany;
using Omegan.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Compensation.Commands.CreateCompensation
{
    public class CreateCompensationCommandHandler: IRequestHandler<CreateCompensationCommandMapper, int>
    {
        private readonly ILogger<CreateCompensationCommandHandler> _logger;
        private readonly IGenericRepository<Omegan.Domain.Compensation, int> _compensationRepository;
        private readonly IMapper _mapper;

        public CreateCompensationCommandHandler(ILogger<CreateCompensationCommandHandler> logger, IGenericRepository<Omegan.Domain.Compensation, int> compensationRepository, IMapper mapper)
        {
            _logger = logger;
            _compensationRepository = compensationRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateCompensationCommandMapper request, CancellationToken cancellationToken)
        {
            var compensationEntity = _mapper.Map<Omegan.Domain.Compensation>(request);

            var result = await _compensationRepository.AddAsync(compensationEntity, cancellationToken);

            if (result is null)
            {
                _logger.LogError("No se inserto el record de compensaciòn");
                throw new Exception("No se pudo insertar el record de la compensaciòn");
            }

            return compensationEntity.Id;

        }
    }
}
