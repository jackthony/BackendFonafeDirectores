/***********
* Nombre del archivo: IAuditServicePassword.cs
* Descripción:        **Define la interfaz para el servicio de auditoría de cambios de contraseña**.
*                     Proporciona un método para **registrar los cambios de contraseña de un usuario**,
*                     incluyendo el ID del usuario, la contraseña antigua (hasheada) y la nueva contraseña (hasheada).
*                     Esta interfaz es crucial para mantener un registro de seguridad de las modificaciones de credenciales.
* Autor:              Daniel Alva
* Fecha de creación:  11/07/2025
* Última modificación:11/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la interfaz IAuditServicePassword.
***********/

namespace Usuario.Application.Auth.Services
{
    public interface IAuditServicePassword
    {
        Task LogChangePasswordAsync(int usuarioId, string oldPassword, string newPassword);
    }
}
