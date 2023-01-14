using Omegan.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Domain
{
    public class Trm: AuditableEntity, IEntity<int>
    {
        public double TRMValue { get; set; }
        public double MonthlyBudget { get; set; }
        public int NumberCompanies { get; set; }
        public double InitialDivision { get; set; }
        public int State { get; set; }
    }
}
