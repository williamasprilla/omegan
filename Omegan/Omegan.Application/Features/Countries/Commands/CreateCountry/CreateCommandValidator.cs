using FluentValidation;
using Omegan.Application.Features.Companies.Commands.CreateCompany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Countries.Commands.CreateCountry
{
    public class CreateCommandValidator: AbstractValidator<CreateCountryCommandMapper>
    {
        public CreateCommandValidator()
        {
            RuleFor(p => p.NameCountry)
                .NotNull().WithMessage("{NameCountry} no puede ser nulo");

            RuleFor(p => p.CurrentValue)
                .NotNull().WithMessage("{CurrentValue} no puede ser nulo");
        }

    }
}
