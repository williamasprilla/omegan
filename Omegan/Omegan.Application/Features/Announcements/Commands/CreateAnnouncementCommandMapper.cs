using MediatR;
using Omegan.Application.DTOs;

namespace Omegan.Application.Features.Announcements.Commands
{

    public class CreateAnnouncementCommandMapper : IRequest<int>
    {
        public string PortShipment { get; set; } = string.Empty;
        public int IdDestinationCountry { get; set; }
        public string DestinationCountry { get; set; } = string.Empty;
        public DateTime ShippingDate { get; set; }
        public string Observation { get; set; } = string.Empty;
        public int State { get; set; }
        public int CompanyId { get; set; }
        public List<ProductAnnouncementInputDTO>? ProductsAnnouncement { get; set; } 
    }

}
