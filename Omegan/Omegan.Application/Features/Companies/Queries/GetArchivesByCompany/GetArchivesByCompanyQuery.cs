using MediatR;
using Omegan.Application.Features.Companies.Queries.GetCompanyByUserId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Companies.Queries.GetCompanyByIdWithArchives
{
    public class GetArchivesByCompanyQuery: IRequest<List<ArchivesByCompanyDTO>>
    {
        public GetArchivesByCompanyQuery(int companyId)
        {
            CompanyId = companyId;     
        }

        public int CompanyId { get; set; }

    }
}
