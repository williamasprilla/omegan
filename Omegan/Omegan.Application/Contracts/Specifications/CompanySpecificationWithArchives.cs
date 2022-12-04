using Ardalis.Specification;
using Omegan.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Contracts.Specifications
{
    public class CompanySpecificationWithArchives: Specification<Archive>
    {
        public CompanySpecificationWithArchives(int companyId)
        {
            Query.Where(c => c.CompanyId == companyId);
        }

    }
}
