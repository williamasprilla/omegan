using FluentValidation;
using Omegan.Application.Features.Countries.Commands.UpdateCountry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.TRM.Commands.UpdateTRM
{
    public class UpdateCommandValidator : AbstractValidator<UpdateTRMCommandMapper>
    {
        public UpdateCommandValidator()
        {
            RuleFor(p => p.TRMValue)
                .NotNull().WithMessage("{TRMValue} no puede ser nulo");

        }
    }
}
