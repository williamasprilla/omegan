using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Utils
{
    public class SendEmail
    {
        public async Task<string> Send(string to, string subject, string body)
        {

            try
            {
                //Leer los valores desde el app.settings
                string from = "wasprilla200511@gmail.com";  //"wasprilla.asprilla@hotmail.com";
                string servidor = "smtp.gmail.com";
                string password = "nafeezlcroabvahe"; //"Isa_2021";
                int port = 587;

                // Se crea el mensaje
                string[] direcciones = to.Split(',');

                MailMessage mensaje = new MailMessage();
                foreach (string email in direcciones)
                {
                    if (!string.IsNullOrEmpty(email))
                    {
                        mensaje.To.Add(email);
                    }
                }


                mensaje.From = new MailAddress(from);
                mensaje.Subject = subject;
                mensaje.Body = body;
                mensaje.IsBodyHtml = true;

                // Se establece una referencia la servidor SMTP
                SmtpClient cliente = new SmtpClient(servidor, port);

                // Establece la configuraci?n del cliente
                cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
                cliente.EnableSsl = true;
                cliente.UseDefaultCredentials = false;
                cliente.Credentials = new NetworkCredential(from, password);

                {
                    cliente.Send(mensaje);
                }

                return "Correo enviado";

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

           

        }

    }
}
