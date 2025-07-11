﻿/***********
 * Nombre del archivo:  EmailService.cs
 * Descripción:         Servicio de envío de correos electrónicos utilizando MailKit y MimeKit.
 *                      Permite enviar correos para recuperación de cuenta, confirmación de cuenta
 *                      y restablecimiento de contraseña. Usa configuración externa definida en EmailSettings.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación de lógica de envío de correos para distintos propósitos del sistema.
 ***********/

using MimeKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using Usuario.Application.Auth.Services;
using Usuario.Infrastructure.Auth.Models;

namespace Usuario.Infrastructure.Auth.Services
{
    public sealed class EmailService : IEmailService
    {
        private readonly EmailSettings _cfg;

        // Constructor para obtener configuraciones desde appsettings
        public EmailService(IOptions<EmailSettings> cfg)
        {
            _cfg = cfg.Value;
        }

        public async Task SendAdminRecoveroyAccountEmailAsync(string nombre, string emailAdmin, string emailUsuario, CancellationToken ct = default)
        {
            // Crear el mensaje MIME
            var msg = new MimeMessage();
            msg.From.Add(MailboxAddress.Parse(_cfg.From));  // Dirección "From"
            msg.To.Add(MailboxAddress.Parse(emailAdmin));           // Dirección del destinatario
            msg.Subject = "Rehabilitar cuenta";         // Asunto del correo

            // Contenido HTML del mensaje
            msg.Body = new TextPart("html")
            {
                Text = $"El usuario: {nombre} con correo: {emailUsuario} ha solicitado la reactivación de su cuenta"
            };

            try
            {
                // Usar SmtpClient de MailKit para enviar el correo
                using var smtp = new SmtpClient();

                // Conectar al servidor SMTP (Hostinger en este caso) usando SSL
                await smtp.ConnectAsync(_cfg.Host, _cfg.Port, SecureSocketOptions.SslOnConnect, ct);

                // Autenticar al servidor con el usuario y la contraseña
                await smtp.AuthenticateAsync(_cfg.User, _cfg.Pass, ct);

                // Enviar el mensaje
                await smtp.SendAsync(msg, ct);

                // Desconectar del servidor SMTP
                await smtp.DisconnectAsync(true, ct);

                // Log para confirmar que el correo fue enviado
                Console.WriteLine($"✅ Correo enviado a {emailAdmin}");
            }
            catch (SmtpCommandException ex) when (ex.ErrorCode == SmtpErrorCode.RecipientNotAccepted)
            {
                // Manejar rechazo de destinatarios
                Console.WriteLine($"⚠️ Destinatario rechazado: {emailAdmin}. Error: {ex.StatusCode}");
                throw;
            }
            catch (SmtpCommandException ex) when ((int)ex.ErrorCode == 535)
            {
                // Manejar fallos en la autenticación
                Console.WriteLine("⚠️ Error de autenticación SMTP. Verifica las credenciales.");
                throw;
            }
            catch (SmtpProtocolException ex)
            {
                // Manejar errores de protocolo SMTP
                Console.WriteLine($"⚠️ Error de protocolo SMTP: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                // Manejar cualquier otro error
                Console.WriteLine($"⚠️ Error inesperado: {ex.Message}");
                throw;
            }
        }

        public async Task SendConfirmationEmailAsync(string to, string resetLink, CancellationToken ct = default)
        {
            // Crear el mensaje MIME
            var msg = new MimeMessage();
            msg.From.Add(MailboxAddress.Parse(_cfg.From));  // Dirección "From"
            msg.To.Add(MailboxAddress.Parse(to));           // Dirección del destinatario
            msg.Subject = "Confirmar cuenta";         // Asunto del correo

            // Contenido HTML del mensaje
            msg.Body = new TextPart("html")
            {
                Text = $"Clic para validar su cuenta:<br/><a href='{resetLink}'>{resetLink}</a>"
            };

            try
            {
                // Usar SmtpClient de MailKit para enviar el correo
                using var smtp = new SmtpClient();

                // Conectar al servidor SMTP (Hostinger en este caso) usando SSL
                await smtp.ConnectAsync(_cfg.Host, _cfg.Port, SecureSocketOptions.SslOnConnect, ct);

                // Autenticar al servidor con el usuario y la contraseña
                await smtp.AuthenticateAsync(_cfg.User, _cfg.Pass, ct);

                // Enviar el mensaje
                await smtp.SendAsync(msg, ct);

                // Desconectar del servidor SMTP
                await smtp.DisconnectAsync(true, ct);

                // Log para confirmar que el correo fue enviado
                Console.WriteLine($"✅ Correo enviado a {to}");
            }
            catch (SmtpCommandException ex) when (ex.ErrorCode == SmtpErrorCode.RecipientNotAccepted)
            {
                // Manejar rechazo de destinatarios
                Console.WriteLine($"⚠️ Destinatario rechazado: {to}. Error: {ex.StatusCode}");
                throw;
            }
            catch (SmtpCommandException ex) when ((int)ex.ErrorCode == 535)
            {
                // Manejar fallos en la autenticación
                Console.WriteLine("⚠️ Error de autenticación SMTP. Verifica las credenciales.");
                throw;
            }
            catch (SmtpProtocolException ex)
            {
                // Manejar errores de protocolo SMTP
                Console.WriteLine($"⚠️ Error de protocolo SMTP: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                // Manejar cualquier otro error
                Console.WriteLine($"⚠️ Error inesperado: {ex.Message}");
                throw;
            }
        }

        // Método para enviar el correo de restablecimiento de contraseña
        public async Task SendPasswordResetEmailAsync(string to, string resetLink, CancellationToken ct = default)
        {
            // Crear el mensaje MIME
            var msg = new MimeMessage();
            msg.From.Add(MailboxAddress.Parse(_cfg.From));  // Dirección "From"
            msg.To.Add(MailboxAddress.Parse(to));           // Dirección del destinatario
            msg.Subject = "Restablecer contraseña";         // Asunto del correo

            // Contenido HTML del mensaje
            msg.Body = new TextPart("html")
            {
                Text = $"Haga clic en el siguiente enlace para restablecer su contraseña:<br/><a href='{resetLink}'>{resetLink}</a>"
            };

            try
            {
                // Usar SmtpClient de MailKit para enviar el correo
                using var smtp = new SmtpClient();

                // Conectar al servidor SMTP (Hostinger en este caso) usando SSL
                await smtp.ConnectAsync(_cfg.Host, _cfg.Port, SecureSocketOptions.SslOnConnect, ct);

                // Autenticar al servidor con el usuario y la contraseña
                await smtp.AuthenticateAsync(_cfg.User, _cfg.Pass, ct);

                // Enviar el mensaje
                await smtp.SendAsync(msg, ct);

                // Desconectar del servidor SMTP
                await smtp.DisconnectAsync(true, ct);

                // Log para confirmar que el correo fue enviado
                Console.WriteLine($"✅ Correo enviado a {to}");
            }
            catch (SmtpCommandException ex) when (ex.ErrorCode == SmtpErrorCode.RecipientNotAccepted)
            {
                // Manejar rechazo de destinatarios
                Console.WriteLine($"⚠️ Destinatario rechazado: {to}. Error: {ex.StatusCode}");
                throw;
            }
            catch (SmtpCommandException ex) when ((int)ex.ErrorCode == 535)
            {
                // Manejar fallos en la autenticación
                Console.WriteLine("⚠️ Error de autenticación SMTP. Verifica las credenciales.");
                throw;
            }
            catch (SmtpProtocolException ex)
            {
                // Manejar errores de protocolo SMTP
                Console.WriteLine($"⚠️ Error de protocolo SMTP: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                // Manejar cualquier otro error
                Console.WriteLine($"⚠️ Error inesperado: {ex.Message}");
                throw;
            }
        }
    }
}