using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Utils
{
    public class PreapprovedData
    {
        public string Company { get; set; }= string.Empty;
        public double Amount { get; set; }

        public int CeroUnoCol { get; set; }
        public double Excedentes { get; set; }
        public decimal Percent { get; set; }
        //public bool Alert { get; set; }
        //public double sumaTotal { get; set; }

        public Totales? datosTotales { get; set; }

    }



    public class Totales
    {
        public double Excedente1 { get; set; }
        public double Excedente2 { get; set; }
        public double ExcedenteIndividual { get; set; }
        public double SumaTotalPreaprobado { get; set; }
        public double SumaTotalRound1 { get; set; }

    }
}
