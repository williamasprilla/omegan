using MediatR;
using Omegan.Application.Features.Announcements.Queries.GetAnnouncementById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Announcements.Queries.GetAnnouncementByCompanyStateQuery
{
    public class GetAnnouncementByCompanyStateQuery: IRequest<AnnouncementDTO>
    {

        public GetAnnouncementByCompanyStateQuery(int idCompany, int state)
        {
            IdCompany = idCompany;
            State = state;
        }
        public int IdCompany { get; set; }
        public int State { get; set; }
    }

}
