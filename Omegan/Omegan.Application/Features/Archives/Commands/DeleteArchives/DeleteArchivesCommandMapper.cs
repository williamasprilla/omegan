using MediatR;
using Omegan.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Archives.Commands.DeleteArchives
{
    public class DeleteArchivesCommandMapper : IRequest
    {
        public int CompanyId { get; set; }

    }
}
