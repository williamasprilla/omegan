using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Omegan.Application.Features.Companies.Queries.GetCompanyByIdWithArchives;
using Omegan.Application.Utils;

namespace Omegan.API.Controllers
{
    
    public class EmailController : ControllerBase
    {

        [HttpGet("SendEmail")]
        public async Task<IActionResult> SendEmail()
        {
            SendEmail email = new SendEmail();
            string to = "william.asprilla.ceballos@gmail.com";
            string subject = "Notificacion Omegan";
            string EmailBody = "Esta es una prueba del envio de correos desde Omegan";
            string from = "wasprilla@hotmail.com";
            string servidor = "smtp.office365.com";
            string password = "";
            int  port = 587;
            await email.Send(to, subject, EmailBody, from, servidor, password, port);

            return Ok("Correo enviado");
        }
    }
}
