using MediatR;

namespace Omegan.Application.Features.Companies.Queries.GetAllCompanyAnnouncements
{
    public class GetAllCompanyAnnouncementsQuery: IRequest<List<CompanyAnnouncementsDTO>>
    {

    }
}
