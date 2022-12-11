using Ardalis.Specification;
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
            Query.Where(c => c.Id == AnnouncementId);
        }
    }
}
