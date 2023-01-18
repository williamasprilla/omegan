using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Omegan.Application.Utils;
using static Omegan.Application.Utils.Enumeraciones;

namespace Omegan.Application.Utils
{
    public class SendEmailHostedService : IHostedService
    {
        SendEmail email = new SendEmail();
        public Task StartAsync(CancellationToken cancellationToken)
        {
            DateTime fecha = DateTime.Now;

            if((int)fecha.DayOfWeek == (int)DiasSemana.Monday)
            {
                //Consultar lista de empresas
                //Extraer el correo del rep legal
                //Enviar correos a todas las empresas
                //Enviar correo notificacion d eenvio de documentos

                
                string to = "wasprilla@hotmail.com";
                string subject = "(Notificacion Omegan)";
                string emailBody = "Para la presentacion de los anuncios se cuenta con 3 dias habilies posterior a la exportación. Debe presentar Factura, DEX y BL";

                _ = email.Send(to, subject, emailBody);
            }


            return Task.CompletedTask;

            //throw new NotImplementedException();

        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
