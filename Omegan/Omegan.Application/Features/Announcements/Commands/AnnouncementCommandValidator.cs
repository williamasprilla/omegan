using FluentValidation;
using Omegan.Application.Features.Companies.Commands.CreateCompany;

namespace Omegan.Application.Features.Announcements.Commands
{
    public class AnnouncementCommandValidator : AbstractValidator<CreateAnnouncementCommandMapper>
    {
        public AnnouncementCommandValidator()
        {
            RuleFor(p => p.PortShipment)
                .NotNull().WithMessage("{NameCompany} no puede ser nulo");

            RuleFor(p => p.Observation)
               .NotNull().WithMessage("{NameCompany} no puede ser nulo");

            RuleFor(p => p.DestinationCountry)
                .NotNull().WithMessage("{NIT} no puede ser nulo");
        }
    }
}
