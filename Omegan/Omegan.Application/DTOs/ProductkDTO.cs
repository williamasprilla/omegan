namespace Omegan.Application.DTOs
{
    public class ProductkDTO
    {
        public int Id { get; set; }
        public string TariffItem { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Kilogram { get; set; } 
        public double OffsetKilogram { get; set;}
        public double Subtotal { get; set; }
    }
}
