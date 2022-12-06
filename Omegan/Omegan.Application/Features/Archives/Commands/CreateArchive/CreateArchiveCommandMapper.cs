using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Archives.Commands.CreateArchive
{
    public class CreateArchiveCommandMapper : IRequest<int>
    {
        public string Name { get; set; } = string.Empty;
        public string Base64 { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public bool State { get; set; }
        public int CompanyId { get; set; }
    }
}
