using MediatR;
using Omegan.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Compensation.Commands.UpdateCompensation
{
    public class UpdateCompensationCommandMapper: IRequest
    {
        public int Id { get; set; }
        public DateTime ExporterDate { get; set; }
        public string AnnouncementNumber { get; set; } = string.Empty;
        public DateTime AnnouncementDate { get; set; }
        public int IdDestinationCountry { get; set; }
        public string DestinationCountry { get; set; } = string.Empty;
        public int CompanyId { get; set; }

    }
}
