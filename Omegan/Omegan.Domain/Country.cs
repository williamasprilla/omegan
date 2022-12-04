using Omegan.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Domain
{
    public class Country : AuditableEntity, IEntity<int>
    {
        public string nameCountry { get; set; } = string.Empty;
        public double CurrentValue { get; set; }
        public bool State { get; set; }

    }
}
