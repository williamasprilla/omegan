using Ardalis.Specification;
using Omegan.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Contracts.Specifications
{
    public class CompensationSpecificationId: Specification<Compensation>
    {

        //public CompensationSpecificationId(int CompensationId)
        //{
        //    Query.Include(pa => pa.ProductCompensation!)
        //         .ThenInclude(p => p.Product);

        //    Query.Where(c => c.Id == CompensationId);
        //}
        public CompensationSpecificationId(int CompensationId)
        {
            Query.Include(pa => pa.ProductCompensations!)
                 .ThenInclude(p => p.Product);

            Query.Where(c => c.AnnouncementNumber == CompensationId);
        }



    }
}
