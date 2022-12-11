using AutoMapper;
using Omegan.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.TRM.Queries
{

    [AutoMap(typeof(Trm), ReverseMap = true)]
    public class TrmDTO
    {
        public int Id { get; set; }
        public double TRMValue { get; set; }
        public double MonthlyBudget { get; set; }
        public int NumberCompanies { get; set; }
        public double InitialDivision { get; set; }
    }
}
