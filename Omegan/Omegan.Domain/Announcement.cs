using Omegan.Domain.Common;

namespace Omegan.Domain
{
    public class Announcement : AuditableEntity, IEntity<int>
    {
        public string PortShipment { get; set; } = string.Empty;

        public int IdDestinationCountry { get; set; }

        public string DestinationCountry { get; set; } = string.Empty;

        public DateTime ShippingDate { get; set; }

        public string Observation { get; set; } = string.Empty;

        public int State { get; set; }

        public bool Ejecucion { get; set; }

        public int CompanyId { get; set; }

        public virtual Company? Company { get; set; } 

        public  ICollection<ProductAnnouncement>? ProductAnnouncements { get; set; } 

    }
}
