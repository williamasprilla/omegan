using MediatR;

namespace Omegan.Application.Features.Companies.Queries.GetCompanyByUserId
{
    public class GetCompanyByUserIdQuery : IRequest<CompanyDTO>
    {
        public GetCompanyByUserIdQuery(string userid)
        {
            UserId = userid ?? throw new ArgumentNullException(nameof(userid));
        }

        public string UserId { get; set; } = string.Empty;

        
    }
}
