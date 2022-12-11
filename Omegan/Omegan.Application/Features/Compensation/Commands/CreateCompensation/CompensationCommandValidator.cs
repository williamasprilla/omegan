using FluentValidation;
using Omegan.Application.Features.Announcements.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Compensation.Commands.CreateCompensation
{
    public class CompensationCommandValidator : AbstractValidator<CreateCompensationCommandMapper>
    {
        public CompensationCommandValidator()
        {
            RuleFor(p => p.AnnouncementNumber)
                .NotNull().WithMessage("{AnnouncementNumber} no puede ser nulo");

            RuleFor(p => p.AnnouncementDate)
               .NotNull().WithMessage("{AnnouncementDate} no puede ser nulo");

            RuleFor(p => p.DestinationCountry)
                .NotNull().WithMessage("{DestinationCountry} no puede ser nulo");
        }

    }
}
