namespace Omegan.Application.DTOs
{
    public class AnnouncementOuputDTO
    {
        public int Id { get; set; }
        public string PortShipment { get; set; } = string.Empty;
        public string DestinationCountry { get; set; } = string.Empty;
        public DateTime ShippingDate { get; set; }
        public string Observation { get; set; } = string.Empty;
        public int State { get; set; }
        public int CompanyId { get; set; }
        public List<ProductkDTO>? ProductsList { get; set; }
    }
}
