using Omegan.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Compensation.Querys
{
    public class CompensationCompanyDTO
    {
        public int Id { get; set; }
        public DateTime ExporterDate { get; set; }
        public string AnnouncementNumber { get; set; } = string.Empty;
        public DateTime AnnouncementDate { get; set; }
        public string DestinationCountry { get; set; } = string.Empty;
        public int CompanyId { get; set; }
        public virtual Company? Company { get; set; }
        public ICollection<ProductCompensation>? ProductCompensation { get; set; }
    }
}
