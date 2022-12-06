using FluentValidation;
using Omegan.Application.Features.Countries.Commands.CreateCountry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Archives.Commands.CreateArchive
{
    public class CreateCommandValidator : AbstractValidator<CreateArchiveCommandMapper>
    {
        public CreateCommandValidator()
        {
            RuleFor(p => p.Name)
                .NotNull().WithMessage("{Name} no puede ser nulo");

            RuleFor(p => p.Base64)
               .NotNull().WithMessage("{Base64} no puede ser nulo");

            RuleFor(p => p.Type)
               .NotNull().WithMessage("{Type} no puede ser nulo");
        }

    }
}
