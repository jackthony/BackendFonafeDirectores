using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Usuario.Application.Auth.Services;

namespace Usuario.Infrastructure.Auth.Services
{
    public class EmailService : IEmailService
    {
        private readonly string _smtpServer = "smtp.hostinger.com"; // Servidor SMTP de Hostinger
        private readonly string _smtpUser = "no-reply@fonafe-directores.com"; // Tu cuenta de correo
        private readonly string _smtpPass = "noreply-Example1"; // Contraseña del correo

        public async Task SendPasswordResetEmailAsync(string email, string resetLink)
        {
            var mailMessage = new MailMessage
            {
                From = new MailAddress("no-reply@fonafe-directores.com"), // Dirección "from"
                Subject = "Restablecer Contraseña",
                Body = $"Haga clic en el siguiente enlace para restablecer su contraseña: {resetLink}",
                IsBodyHtml = true
            };

            // Asegúrate de incluir la dirección del destinatario
            mailMessage.To.Add(email);

            using (var smtpClient = new SmtpClient(_smtpServer))
            {
                smtpClient.Credentials = new NetworkCredential(_smtpUser, _smtpPass);
                smtpClient.Port = 465; // Puerto para SSL
                smtpClient.EnableSsl = true; // Usar SSL para cifrado
                await smtpClient.SendMailAsync(mailMessage); // Enviar correo asíncronamente
            }
        }
    }
}