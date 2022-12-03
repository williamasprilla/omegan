using Ardalis.Specification;
using Omegan.Domain;

namespace Omegan.Application.Contracts.Specifications
{
    public class CompanySpecification : Specification<Company>
    {
        public CompanySpecification(string userid)
        {

            Query.Include(a => a.Archives)
                 .Include(n => n.Announcements)
                 .ThenInclude(pa => pa.ProductAnnouncements)
                 .ThenInclude(p => p.Product);


            Query.Where(c => c.UserId == userid);


        }


        public CompanySpecification()
        {

            Query.Include(n => n.Announcements)
                 .ThenInclude(pa => pa.ProductAnnouncements)
                 .ThenInclude(p => p.Product);



        }


       
    }
}
