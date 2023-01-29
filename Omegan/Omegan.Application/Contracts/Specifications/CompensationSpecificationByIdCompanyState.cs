using Ardalis.Specification;
using MediatR;
using Omegan.Application.Features.Compensation.Querys.GetCompensationById;
using Omegan.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Contracts.Specifications
{
    public class CompensationSpecificationByIdCompanyState: Specification<Compensation>
    {
        public CompensationSpecificationByIdCompanyState(int CompanytId, int state)
        {
            Query.Include(pa => pa.ProductCompensations!)
                 .ThenInclude(p => p.Product);

            Query.Where(c => c.CompanyId == CompanytId && c.State == state);

        }


    }
}
