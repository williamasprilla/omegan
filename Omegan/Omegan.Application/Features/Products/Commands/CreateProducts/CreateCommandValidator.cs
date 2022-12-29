using FluentValidation;
using Omegan.Application.Features.Companies.Commands.CreateCompany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Products.Commands.CreateProduct
{
    public class CreateCommandValidator : AbstractValidator<CreateProductsCommandMapper>
    {
        public CreateCommandValidator()
        {
            RuleFor(p => p.TariffItem)
                .NotNull().WithMessage("{TariffItem} no puede ser nulo");

            RuleFor(p => p.Description)
                .NotNull().WithMessage("{Description} no puede ser nulo");
        }
    }
}
