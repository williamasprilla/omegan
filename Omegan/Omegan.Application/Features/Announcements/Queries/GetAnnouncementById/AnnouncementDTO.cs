using Omegan.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Announcements.Queries.GetAnnouncementById
{
    public class AnnouncementDTO
    {
        public string PortShipment { get; set; } = string.Empty;
        public string DestinationCountry { get; set; } = string.Empty;
        public DateTime ShippingDate { get; set; }
        public string Observation { get; set; } = string.Empty;
        public int State { get; set; }
        public int CompanyId { get; set; }
        //public List<ProductAnnouncementInputDTO>? ProductsAnnouncement { get; set; }
        public virtual ICollection<ProductkDTO>? Announcements { get; set; }
    }
}
