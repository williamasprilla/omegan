using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Omegan.Application.Contracts.Persistence;
using Omegan.Application.Contracts.Specifications;
using Omegan.Application.Features.Companies.Commands.CreateCompany;
using Omegan.Domain;

namespace Omegan.Application.Features.Companies.Queries.GetCompanyByUserId
{
    public class GetCompanyByUserIdQueryHandler : IRequestHandler<GetCompanyByUserIdQuery, CompanyDTO>
    {

        private readonly ILogger<GetCompanyByUserIdQueryHandler> _logger;
        private readonly IGenericRepository<Company, int> _companyRepository;
        private readonly IMapper _mapper;

        public GetCompanyByUserIdQueryHandler(ILogger<GetCompanyByUserIdQueryHandler> logger, IGenericRepository<Company, int> companyRepository, IMapper mapper)
        {
            _logger = logger;
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        public async  Task<CompanyDTO> Handle(GetCompanyByUserIdQuery request, CancellationToken cancellationToken)
        {
            var specification = new CompanySpecification(request.UserId);

            var company = await _companyRepository.FirstAsync(specification, cancellationToken);


            var result = _mapper.Map<CompanyDTO>(company);

            return result;
        }
    }
}
