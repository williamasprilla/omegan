using FluentValidation;
using Omegan.Application.Features.Countries.Commands.UpdateCountry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Countries.Commands.DeleteCountry
{
    public class DeleteCommandValidator: AbstractValidator<UpdateCountryCommandMapper>
    {
        public DeleteCommandValidator()
        {
            
        }
    }
}
