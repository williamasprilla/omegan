using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Countries.Commands.CreateCountry
{
    public class CreateCountryCommandMapper: IRequest<int>
    {
        public string NameCountry { get; set; } = string.Empty;
        public double CurrentValue { get; set; }
        public bool State { get; set; }

    }
}
