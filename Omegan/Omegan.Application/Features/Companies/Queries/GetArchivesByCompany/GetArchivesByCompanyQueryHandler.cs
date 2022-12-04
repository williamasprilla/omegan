using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Omegan.Application.Contracts.Persistence;
using Omegan.Application.Contracts.Specifications;
using Omegan.Application.Features.Companies.Queries.GetCompanyByUserId;
using Omegan.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Companies.Queries.GetCompanyByIdWithArchives
{
    public class GetArchivesByCompanyQueryHandler : IRequestHandler<GetArchivesByCompanyQuery, List<ArchivesByCompanyDTO>>
    {

        //private readonly ILogger<GetArchivesByCompanyQueryHandler> _logger;
        private readonly IGenericRepository<Archive, int> _archiveRepository;
        private readonly IMapper _mapper;


        public GetArchivesByCompanyQueryHandler(IGenericRepository<Archive, int> archiveRepository, IMapper mapper)
        {
            //_logger = logger;
            _archiveRepository = archiveRepository;
            _mapper = mapper;
        }


        public async Task<List<ArchivesByCompanyDTO>> Handle(GetArchivesByCompanyQuery request, CancellationToken cancellationToken)
        {
            var specification = new CompanySpecificationWithArchives(request.CompanyId);

            var archives = await _archiveRepository.ListAsync(specification, cancellationToken);

            var result = _mapper.Map<List<ArchivesByCompanyDTO>>(archives);


            return result;
        }



    }
}
