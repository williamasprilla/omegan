using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Domain
{
    public class ProductCompensation
    {
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public int CompensationId { get; set; }
        public Compensation? Compensation { get; set; }
        public double KilogramsExported { get; set; }
        public double OffsetKilogram { get; set; }
        public double Subtotal { get; set; }
    }
}
