﻿using Ardalis.Specification;
using Omegan.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Contracts.Specifications
{
    public class AnnouncementSpecificationByIdCompany: Specification<Announcement>
    {
        public AnnouncementSpecificationByIdCompany(int CompanytId)
        {
            Query.Include(pa => pa.ProductAnnouncements)
                 .ThenInclude(p => p.Product);

            Query.Where(c => c.Id == CompanytId);
        }
    }
}