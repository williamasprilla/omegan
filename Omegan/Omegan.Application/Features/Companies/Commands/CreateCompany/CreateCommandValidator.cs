using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Companies.Commands.CreateCompany
{
    public class CreateCommandValidator : AbstractValidator<CreateCompanyCommandMapper>
    {
        public CreateCommandValidator()
        {
            RuleFor(p => p.NameCompany)
                .NotNull().WithMessage("{NameCompany} no puede ser nulo");

            RuleFor(p => p.NIT)
                .NotNull().WithMessage("{NIT} no puede ser nulo");
        }
    }
}
