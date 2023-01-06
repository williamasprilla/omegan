using MediatR;
using Omegan.Application.Features.Announcements.Queries.GetAnnouncementById;
using Omegan.Application.Features.Compensation.Querys.GetCompensationById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Compensation.Querys.GetCompensationByCompanyStateQuery
{
    public class GetCompensationByCompanyStateQuery: IRequest<List<CompensationDTO>>
    {
        public GetCompensationByCompanyStateQuery(int idCompany, int state)
        {
            IdCompany = idCompany;
            State = state;
        }
        public int IdCompany { get; set; }
        public int State { get; set; }

    }
}
