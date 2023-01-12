using FluentValidation;
using Omegan.Application.Features.Countries.Commands.UpdateCountry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Archives.Commands.DeleteArchives
{
    public class DeleteCommandValidator : AbstractValidator<DeleteArchivesCommandMapper>
    {
        public DeleteCommandValidator()
        {

        }
    }
}
