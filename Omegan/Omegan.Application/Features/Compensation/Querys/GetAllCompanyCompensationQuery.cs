using MediatR;
using Omegan.Application.Features.Companies.Queries.GetAllCompanyAnnouncements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Compensation.Querys
{
    public class GetAllCompanyCompensationQuery: IRequest<List<CompanyCompensationDTO>>
    {

    }
}
