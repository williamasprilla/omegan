using FluentValidation;
using Omegan.Application.Features.Companies.Commands.UpdateCompany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Announcements.Commands.UpdateAnnouncement
{
    public class UpdateCommandValidator: AbstractValidator<UpdateAnnouncementCommandMapper>
    {
        public UpdateCommandValidator()
        {
            

        }

    }
}
