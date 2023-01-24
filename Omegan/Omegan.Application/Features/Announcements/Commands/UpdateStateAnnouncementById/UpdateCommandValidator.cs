using FluentValidation;
using Omegan.Application.Features.Announcements.Commands.UpdateAnnouncement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Announcements.Commands.UpdateStateAnnouncementById
{
    public class UpdateCommandValidator : AbstractValidator<UpdateStateAnnouncementByIdCommandMapper>
    {
        public UpdateCommandValidator()
        {

        }
    }
}
