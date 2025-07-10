/***********
* Nombre del archivo: IEmailService.cs
* Descripción:        **Define la interfaz para el servicio de envío de correos electrónicos** en la aplicación.
*                     Proporciona métodos para enviar diferentes tipos de notificaciones por correo,
*                     como correos de restablecimiento de contraseña, correos de confirmación de cuenta
*                     y correos de recuperación de cuenta dirigidos a administradores.
*                     Facilita la comunicación con los usuarios y administradores de forma desacoplada y eficiente.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la interfaz IEmailService.
***********/

namespace Usuario.Application.Auth.Services
{
    public interface IEmailService
    {
        Task SendPasswordResetEmailAsync(string to, string resetLink, CancellationToken ct = default);
        Task SendConfirmationEmailAsync(string to, string resetLink, CancellationToken ct = default);
        Task SendAdminRecoveroyAccountEmailAsync(string nombre, string emailAdmin, string emailUsuario,CancellationToken ct = default);
    }
}
