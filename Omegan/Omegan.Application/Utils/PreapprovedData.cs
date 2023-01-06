using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Utils
{
    public class PreapprovedData
    {
        public string Company { get; set; }= string.Empty;
        public double Amount { get; set; }
        public double Residue { get; set; }
        public decimal Percent { get; set; }
        public bool Alert { get; set; }
    }
}
