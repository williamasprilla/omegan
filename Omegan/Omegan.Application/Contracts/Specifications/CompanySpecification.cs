using Ardalis.Specification;
using Omegan.Domain;
using System.Security.Cryptography.X509Certificates;

namespace Omegan.Application.Contracts.Specifications
{
    public class CompanySpecification : Specification<Company>
    {
        public CompanySpecification(string userid)
        {

            Query.Include(a => a.Archives!)
                 .Include(n => n.Announcements!)
                 .ThenInclude(pa => pa.ProductAnnouncements!)
                 .ThenInclude(p => p.Product);


            Query.Where(c => c.UserId == userid);


        }


        public CompanySpecification()
        {
            Query.Include(n => n.Announcements!)
                 .ThenInclude(pa => pa.ProductAnnouncements!)
                 .ThenInclude(p => p.Product);
        }



        public CompanySpecification(int id)
        {
            Query.Include(a => a.Archives)!
                 //.Include(n => n.Announcements!)
                 .Include(n => n.Announcements!.Where(o => o.State==2))
                 .ThenInclude(pa => pa.ProductAnnouncements)!
                 .ThenInclude(p => p.Product);



            Query.Where(c => c.Id == id);

            //Query.Where(n => n.Announcements!.Any(a => a.State == 2));

            //Query.Where(c => c.Id == id && c.Announcements!.Any(a => a.State == 2) );

        }
    }
}
