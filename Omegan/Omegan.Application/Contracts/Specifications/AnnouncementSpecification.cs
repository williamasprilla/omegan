using Ardalis.Specification;
using Omegan.Application.Features.Announcements.Queries.GetAnnouncementById;
using Omegan.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Contracts.Specifications
{
    public class AnnouncementSpecification: Specification<Announcement>
    {
        public AnnouncementSpecification(int AnnouncementId)
        {
            Query.Include(pa => pa.ProductAnnouncements!)
                 .ThenInclude(p => p.Product);

            Query.Where(c => c.Id == AnnouncementId);
        }

       

    }
}
