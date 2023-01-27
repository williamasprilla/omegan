﻿using Omegan.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Companies.Queries.GetAllCompanyCompensationsQuery
{
    public class CompanyCompensationsDTO
    {
        public DateTime ExporterDate { get; set; }
        public int AnnouncementNumber { get; set; }
        public DateTime AnnouncementDate { get; set; }
        public int IdDestinationCountry { get; set; }
        public string DestinationCountry { get; set; } = string.Empty;
        public int State { get; set; }
        public bool Ejecucion { get; set; }
        public int CompanyId { get; set; }
        public virtual Company? Company { get; set; }
        public ICollection<ProductCompensation>? ProductCompensation { get; set; }
    }
}