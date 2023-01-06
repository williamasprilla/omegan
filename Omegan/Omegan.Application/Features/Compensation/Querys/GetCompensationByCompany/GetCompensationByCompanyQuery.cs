using MediatR;
using Omegan.Application.Features.Announcements.Queries.GetAnnouncementById;
using Omegan.Application.Features.Compensation.Querys.GetCompensationById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Compensation.Querys.GetCompensationByCompany
{
    public class GetCompensationByCompanyQuery: IRequest<CompensationDTO>
    {
        public GetCompensationByCompanyQuery(int idCompany)
        {
            IdCompany = idCompany;
        }
        public int IdCompany { get; set; }

    }
}
