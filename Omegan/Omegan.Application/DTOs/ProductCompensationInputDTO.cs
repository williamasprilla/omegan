using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.DTOs
{
    public class ProductCompensationInputDTO
    {
        public int ProductId { get; set; }
        public double KilogramsExported { get; set; }
        public double OffsetKilogram { get; set; }
        public double Subtotal { get; set; }

    }
}
