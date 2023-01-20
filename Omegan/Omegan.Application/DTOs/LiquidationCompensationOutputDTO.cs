using Omegan.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.DTOs
{
    public class LiquidationCompensationOutputDTO
    {
        public int Id { get; set; }
        public DateTime ExporterDate { get; set; }
        public DateTime FilingDate { get; set; }
        public string? liquidationDate { get; set; }
        public string Agreement { get; set; } = string.Empty;
        public string CompensatedProduct { get; set; } = string.Empty;
        public int AnnouncementNumber { get; set; }
        public DateTime AnnouncementDate { get; set; }
        public int IdDestinationCountry { get; set; }
        public string DestinationCountry { get; set; } = string.Empty;
        public string Exporter { get; set; } = string.Empty;
        public int State { get; set; }
        public int CompanyId { get; set; }
        public double TRM { get; set; }
        public string ProductCompensated { get; set; } = string.Empty;
        public string MonthCompensate { get; set; } = string.Empty;
        
        public string TariffItem { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal KilogramsExported { get; set; }
        public double OffsetKilogram { get; set; }
        public double OffsetValueKilogram { get; set; }
        public double CompensationValue { get; set; }
        //public virtual Company? Company { get; set; }
        //public ICollection<ProductCompensation>? ProductCompensation { get; set; }

    }
}
