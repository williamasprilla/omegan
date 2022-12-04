using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Companies.Queries.GetCountries
{
    public class GetCountriesDTO
    {
        public string nameCountry { get; set; } = string.Empty;
        public double CurrentValue { get; set; }
        public bool State { get; set; }
    }
}
