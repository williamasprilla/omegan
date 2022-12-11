using FluentValidation;
using Omegan.Application.Features.Countries.Commands.CreateCountry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.TRM.Commands.CreateTRM
{
    public class CreateCommandValidator : AbstractValidator<CreateTRMCommandMapper>
    {
        public CreateCommandValidator()
        {
            RuleFor(p => p.TRMValue)
                .NotNull().WithMessage("{TRMValue} no puede ser nulo");

            RuleFor(p => p.NumberCompanies)
                .NotNull().WithMessage("{NumberCompanies} no puede ser nulo");

            RuleFor(p => p.MonthlyBudget)
                .NotNull().WithMessage("{MonthlyBudget} no puede ser nulo");

            RuleFor(p => p.InitialDivision)
                .NotNull().WithMessage("{InitialDivision} no puede ser nulo");
        }
    }
}
