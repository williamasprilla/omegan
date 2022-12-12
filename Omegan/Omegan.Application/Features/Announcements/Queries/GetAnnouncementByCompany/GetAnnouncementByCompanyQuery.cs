using MediatR;
using Omegan.Application.Features.Announcements.Queries.GetAnnouncementById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Announcements.Queries.GetAnnouncementByCompany
{
    public class GetAnnouncementByCompanyQuery: IRequest<AnnouncementDTO>
    {
        public GetAnnouncementByCompanyQuery(int idCompany)
        {
            IdCompany = idCompany;
        }
        public int IdCompany { get; set; }
    }
}
