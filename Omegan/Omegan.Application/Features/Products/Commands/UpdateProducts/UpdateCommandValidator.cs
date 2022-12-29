using FluentValidation;
using Omegan.Application.Features.Companies.Commands.UpdateCompany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Products.Commands.UpdateProducts
{
    public class UpdateCommandValidator : AbstractValidator<UpdateProductsCommandMapper>
    {
        public UpdateCommandValidator()
        {
            RuleFor(p => p.TariffItem)
                .NotNull().WithMessage("{TariffItem} no puede ser nulo");

            RuleFor(p => p.Description)
                .NotNull().WithMessage("{Description} no puede ser nulo");

        }
    }
}
