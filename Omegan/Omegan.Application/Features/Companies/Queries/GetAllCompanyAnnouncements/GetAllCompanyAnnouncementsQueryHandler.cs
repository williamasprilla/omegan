
using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Omegan.Application.Contracts.Persistence;
using Omegan.Application.Contracts.Specifications;
using Omegan.Domain;


namespace Omegan.Application.Features.Companies.Queries.GetAllCompanyAnnouncements
{
    public class GetAllCompanyAnnouncementsQueryHandler: IRequestHandler<GetAllCompanyAnnouncementsQuery, List<CompanyAnnouncementsDTO>>
    {
        //private readonly ILogger<GetAllCompanyAnnouncementsQuery> _logger;
        private readonly IGenericRepository<Company, int> _companyRepository;
        private readonly IMapper _mapper;


        public GetAllCompanyAnnouncementsQueryHandler(IGenericRepository<Company, int> companyRepository, IMapper mapper)
        {
            //_logger = logger;
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        public async Task<List<CompanyAnnouncementsDTO>> Handle(GetAllCompanyAnnouncementsQuery request, CancellationToken cancellationToken)
        {

            var specification = new CompanySpecification();

            var company = await _companyRepository.ListAsync(specification, cancellationToken);
            var result = _mapper.Map<List<CompanyAnnouncementsDTO>>(company);
            return result;
        }


    }

}