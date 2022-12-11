using MediatR;
using Omegan.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Compensation.Commands.CreateCompensation
{
    public class CreateCompensationCommandMapper : IRequest<int>
    {
        public DateTime ExporterDate { get; set; }
        public string AnnouncementNumber { get; set; } = string.Empty;
        public DateTime AnnouncementDate { get; set; }
        public string DestinationCountry { get; set; } = string.Empty;
        public int CompanyId { get; set; }
        public List<ProductCompensationInputDTO>? ProductsCompensation { get; set; }
    }
}
