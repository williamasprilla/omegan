using FluentValidation;
using Omegan.Application.Features.Countries.Commands.UpdateCountry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Companies.Commands.DeleteCompany
{
    public class DeleteCommandValidator : AbstractValidator<DeleteCompanyCommandMapper>
    {
        public DeleteCommandValidator()
        {

        }
    }
}
