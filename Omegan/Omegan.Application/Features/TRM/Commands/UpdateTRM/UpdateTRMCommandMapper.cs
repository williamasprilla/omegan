using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.TRM.Commands.UpdateTRM
{
    public class UpdateTRMCommandMapper: IRequest
    {
        public int Id { get; set; }
        public double TRMValue { get; set; }
        public double MonthlyBudget { get; set; }
        public int NumberCompanies { get; set; }
        public double InitialDivision { get; set; }
    }

}
