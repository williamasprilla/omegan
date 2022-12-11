using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Omegan.Application.Contracts.Persistence;
using Omegan.Application.Features.Countries.Commands.CreateCountry;
using Omegan.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.TRM.Commands.CreateTRM
{
    public class CreateTRMCommandHandler: IRequestHandler<CreateTRMCommandMapper, int>
    {
        private readonly ILogger<CreateTRMCommandHandler> _logger;
        private readonly IGenericRepository<Trm, int> _trmRepository;
        private readonly IMapper _mapper;

        public CreateTRMCommandHandler(ILogger<CreateTRMCommandHandler> logger, IGenericRepository<Trm, int> trmRepository, IMapper mapper)
        {
            _logger = logger;
            _trmRepository = trmRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateTRMCommandMapper request, CancellationToken cancellationToken)
        {
            var trmEntity = _mapper.Map<Trm>(request);

            var result = await _trmRepository.AddAsync(trmEntity, cancellationToken);

            if (result is null)
            {
                _logger.LogError("No se inserto el TRM");
                throw new Exception("No se pudo insertar el TRM");
            }

            return trmEntity.Id;
        }
    }
}
