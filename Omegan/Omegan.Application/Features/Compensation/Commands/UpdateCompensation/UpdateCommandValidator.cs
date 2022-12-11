using FluentValidation;
using Omegan.Application.Features.Announcements.Commands.UpdateAnnouncement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Compensation.Commands.UpdateCompensation
{
    public class UpdateCommandValidator : AbstractValidator<UpdateCompensationCommandMapper>
    {
        public UpdateCommandValidator()
        {
        }
    }
}
