using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Countries.Commands.DeleteCountry
{
    public class DeleteCountryCommandMapper : IRequest
    {
        public int Id { get; set; }
       

    }
}
