using MediatR;
using Omegan.Application.Features.Companies.Queries.GetAllCompanyAnnouncements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Companies.Queries.GetAllCompanyCompensationsQuery
{
    public class GetAllCompanyCompensationQuery : IRequest<List<CompanyCompensationsDTO>>
    {
        public GetAllCompanyCompensationQuery(int state)
        {
            State = state;
        }
        public int State { get; set; }
    }


}
