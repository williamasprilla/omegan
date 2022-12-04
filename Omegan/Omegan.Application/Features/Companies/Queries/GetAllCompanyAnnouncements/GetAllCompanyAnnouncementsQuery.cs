using MediatR;
using Omegan.Application.Features.Companies.Queries.GetCountries;

namespace Omegan.Application.Features.Companies.Queries.GetAllCompanyAnnouncements
{
    public class GetAllCompanyAnnouncementsQuery: IRequest<List<CompanyAnnouncementsDTO>>
    {

    }
}
