using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Omegan.Application.Features.Companies.Queries.GetCompanyByIdWithArchives;
using Omegan.Application.Utils;

namespace Omegan.API.Controllers
{
    
    public class EmailController : ControllerBase
    {

        [HttpGet("SendEmail")]
        public async Task<IActionResult> SendEmail(string to, string subject, string emailBody)
        {
            SendEmail email = new SendEmail();
            //string to = "william.asprilla.ceballos@gmail.com";
            //string subject = "Notificacion Omegan";
            //string EmailBody = "Esta es una prueba del envio de correos desde Omegan";
            
            await email.Send(to, subject, emailBody);

            return Ok("Correo enviado");
        }
    }
}
