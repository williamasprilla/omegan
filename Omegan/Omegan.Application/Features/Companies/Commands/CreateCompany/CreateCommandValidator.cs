using FluentValidation;

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
