using MediatR;
using Omegan.Application.DTOs;
using Omegan.Domain;
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
        public DateTime FilingDate { get; set; }
        public int AnnouncementNumber { get; set; }
        public DateTime AnnouncementDate { get; set; }
        public int IdDestinationCountry { get; set; }
        public string DestinationCountry { get; set; } = string.Empty;
        public int State { get; set; }
        public bool Ejecucion { get; set; }
        public int CompanyId { get; set; }
        public List<ProductCompensationInputDTO>? ProductsCompensation { get; set; }


    }
}
