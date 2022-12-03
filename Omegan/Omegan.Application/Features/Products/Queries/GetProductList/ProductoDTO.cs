using AutoMapper;
using Omegan.Domain;

namespace Omegan.Application.Features.Products.Queries.GetProductList
{
    [AutoMap(typeof(Product), ReverseMap = true)]
    public class ProductoDTO
    {
        public int Id { get; set; }
        public string TariffItem { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

    }
}
