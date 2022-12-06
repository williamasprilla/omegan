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

namespace Omegan.Application.Features.Archives.Commands.CreateArchive
{
    public class CreateArchiveCommandHandler: IRequestHandler<CreateArchiveCommandMapper, int>
    {

        private readonly ILogger<CreateArchiveCommandHandler> _logger;
        private readonly IGenericRepository<Archive, int> _archiveRepository;
        private readonly IMapper _mapper;

        public CreateArchiveCommandHandler(ILogger<CreateArchiveCommandHandler> logger, IGenericRepository<Archive, int> archiveRepository, IMapper mapper)
        {
            _logger = logger;
            _archiveRepository = archiveRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateArchiveCommandMapper request, CancellationToken cancellationToken)
        {
            var archiveEntity = _mapper.Map<Archive>(request);
            var result = await _archiveRepository.AddAsync(archiveEntity, cancellationToken);
            if (result is null)
            {
                _logger.LogError("No se inserto el archivo");
                throw new Exception("No se pudo insertar el archivo");
            }
            return archiveEntity.Id;
        }
    }
}
