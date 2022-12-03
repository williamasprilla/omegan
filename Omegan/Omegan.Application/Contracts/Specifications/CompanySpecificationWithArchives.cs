using Ardalis.Specification;
using Omegan.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Contracts.Specifications
{
    public class CompanySpecificationWithArchives: Specification<Archive>
    {
        public CompanySpecificationWithArchives(int userid)
        {

            //Query.Include(a => a.Archives)
                 //.Include(n => n.Announcements);
                 //.ThenInclude(pa => pa.ProductAnnouncements)
                 //.ThenInclude(p => p.Product);


            Query.Where(c => c.CompanyId == userid);


        }


    }
}
