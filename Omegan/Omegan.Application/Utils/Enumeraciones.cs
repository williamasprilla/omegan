using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Utils
{
    public class Enumeraciones
    {
        public enum EstadosAnuncios
        {
            Creacido = 2,
            Eliminado = 0,
            Desactivado = 1
            
        }



        public enum EstadosCompanies
        {
            Creada  = 0,
            AProbada = 1,
            AprobadaConvenio = 2,
            RadicacionDocExportacion = 3
        }



        public enum DiasSemana
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thrsday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday  = 0
        }

    }
}
