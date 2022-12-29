using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Products.Commands.UpdateProducts
{
    public class UpdateProductsCommandMapper : IRequest
    {
        public int Id { get; set; }
        public string TariffItem { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
