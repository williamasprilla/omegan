﻿using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Omegan.Application.Contracts.Persistence;
using Omegan.Application.Contracts.Specifications;
using Omegan.Application.Exceptions;
using Omegan.Application.Features.Companies.Commands.DeleteCompany;
using Omegan.Application.Features.Countries.Commands.DeleteCountry;
using Omegan.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Archives.Commands.DeleteArchives
{
    public class DeleteArchivesCommandHandler: IRequestHandler<DeleteArchivesCommandMapper>
    {

        private readonly ILogger<DeleteArchivesCommandHandler> _logger;
        private readonly IGenericRepository<Archive, int> _archivesRepository;
        private readonly IMapper _mapper;

        public DeleteArchivesCommandHandler(ILogger<DeleteArchivesCommandHandler> logger, IGenericRepository<Archive, int> archivesRepository, IMapper mapper)
        {
            _logger = logger;
            _archivesRepository = archivesRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteArchivesCommandMapper request, CancellationToken cancellationToken)
        {
            var specification = new ArchiveSpecificationByIdCompany(request.CompanyId);


            var archivesToDelete = await _archivesRepository.FirstOrDefaultAsync(specification, cancellationToken);

            if (archivesToDelete != null)
            {
                //    //_logger.LogError($"{request.CompanyId} archivos de la compañia no existen en el sistema ");
                //    //throw new NotFoundException(nameof(Archive), request.CompanyId);

                //    return Unit.Value;


                _mapper.Map(request, archivesToDelete, typeof(DeleteArchivesCommandMapper), typeof(Archive));

                await _archivesRepository.DeleteAsync(archivesToDelete, cancellationToken);

                _logger.LogInformation($"Los archivos de la compañia {request.CompanyId} fueron eliminados con exito");

                return Unit.Value;

            }

            return Unit.Value;


        }
    }
}