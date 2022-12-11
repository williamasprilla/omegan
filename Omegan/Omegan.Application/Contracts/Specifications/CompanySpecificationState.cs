using Ardalis.Specification;
using Omegan.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Contracts.Specifications
{
    public class CompanySpecificationState: Specification<Company>
    {
        public CompanySpecificationState(int state)
        {
            Query.Where(c => c.State == state);
        }
    }
}
