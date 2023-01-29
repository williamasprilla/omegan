using Omegan.Application.DTOs;
using Omegan.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Compensation.Querys.GetCompensationById
{
    public class CompensationDTO
    {
        public int Id { get; set; }
        public DateTime ExporterDate { get; set; }
        public DateTime FilingDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string AnnouncementNumber { get; set; } = string.Empty;
        public DateTime AnnouncementDate { get; set; }
        public int IdDestinationCountry { get; set; }
        public string DestinationCountry { get; set; } = string.Empty;
        public int State { get; set; }
        public int Ejecucion { get; set; }
        public int CompanyId { get; set; }
        public List<ProductkDTO>? ProductsList { get; set; }


    }
}
