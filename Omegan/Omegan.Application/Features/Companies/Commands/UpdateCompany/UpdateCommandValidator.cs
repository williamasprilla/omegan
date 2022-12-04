using FluentValidation;
using Omegan.Application.Features.Countries.Commands.UpdateCountry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Companies.Commands.UpdateCompany
{
    public class UpdateCommandValidator : AbstractValidator<UpdateCompanyCommandMapper>
    {    
        public UpdateCommandValidator()
        {
            RuleFor(p => p.NIT)
                .NotNull().WithMessage("{NIT} no puede ser nulo");

            RuleFor(p => p.NameCompany)
                .NotNull().WithMessage("{NameCompany} no puede ser nulo");
            
        }
    }
}
