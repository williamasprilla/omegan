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

namespace Omegan.Application.Features.Companies.Queries.GetCompanyById
{
    public class GetCompanyByIdQueryHandler : IRequestHandler<GetCompanyByIdQuery, CompanyDTO>
    {

        private readonly ILogger<GetCompanyByIdQueryHandler> _logger;
        private readonly IGenericRepository<Company, int> _companyRepository;
        private readonly IMapper _mapper;

        public GetCompanyByIdQueryHandler(ILogger<GetCompanyByIdQueryHandler> logger, IGenericRepository<Company, int> companyRepository, IMapper mapper)
        {
            _logger = logger;
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        public async Task<CompanyDTO> Handle(GetCompanyByIdQuery request, CancellationToken cancellationToken)
        {
            var specification = new CompanySpecification(request.Id);

            //var company = await _companyRepository.FirstAsync(specification, cancellationToken);
            var company = await _companyRepository.FirstOrDefaultAsync(specification, cancellationToken);


            var result = _mapper.Map<CompanyDTO>(company);

            return result;
        }
    }

}
