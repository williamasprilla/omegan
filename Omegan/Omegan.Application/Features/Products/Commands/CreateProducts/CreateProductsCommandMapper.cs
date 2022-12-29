using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Products.Commands.CreateProduct
{
    public class CreateProductsCommandMapper: IRequest<int>
    {
        public int Id { get; set; }
        public string TariffItem { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
