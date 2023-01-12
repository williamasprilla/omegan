using Ardalis.Specification;
using Omegan.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Contracts.Specifications
{
    public class ArchiveSpecificationByIdCompany: Specification<Archive>
    {
        public ArchiveSpecificationByIdCompany(int CompanyId)
        {
            Query.Where(c => c.CompanyId == CompanyId);
        }
    }
}
