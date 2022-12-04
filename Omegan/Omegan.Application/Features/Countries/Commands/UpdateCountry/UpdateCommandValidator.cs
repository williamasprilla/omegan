using FluentValidation;
using Omegan.Application.Features.Countries.Commands.CreateCountry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Countries.Commands.UpdateCountry
{
    public class UpdateCommandValidator: AbstractValidator<UpdateCountryCommandMapper>
    {
        public UpdateCommandValidator()
        {
            RuleFor(p => p.NameCountry)
                .NotNull().WithMessage("{NameCountry} no puede ser nulo");

            RuleFor(p => p.CurrentValue)
                .NotNull().WithMessage("{CurrentValue} no puede ser nulo");
        }
    }
}
