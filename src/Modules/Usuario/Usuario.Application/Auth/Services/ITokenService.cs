/***********
* Nombre del archivo: ITokenService.cs
* Descripción:        **Define la interfaz para los servicios de gestión de tokens** (JWT y Refresh Tokens)
*                     en la aplicación de autenticación. Proporciona métodos para generar, validar y extraer
*                     información de tokens de acceso, tokens de refresco, tokens de restablecimiento de contraseña
*                     y tokens de confirmación de cuenta, facilitando la seguridad y la gestión de sesiones.
* Autor:              Daniel Alva
* Fecha de creación:  11/07/2025
* Última modificación:11/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la interfaz ITokenService.
***********/

using System.Security.Claims;

namespace Usuario.Application.Auth.Services
{
    public interface ITokenService
    {
        public string GenerateAccessToken(int userId, string email, IList<string> roles, string sessionGuid);
        public string GenerateRefreshToken();
        public ClaimsPrincipal? ValidateAccessToken(string token);
        public int? GetUserIdFromExpiredToken(string token);
        public string GenerateResetPasswordToken(int userId);
        public string GenerateConfirmationToken(int userId);
        public int? GetUsuarioIdFromClaims(ClaimsPrincipal? claimsPrincipal);
    }
}
