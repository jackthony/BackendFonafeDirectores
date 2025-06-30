using Shared.Kernel.Responses;
using Usuario.Domain.Auth.Models;
using Usuario.Domain.Auth.Parameters;
using Usuario.Domain.Auth.Results;

namespace Usuario.Domain.Auth.Repositories
{
    public interface IAuthRepository
    {
        Task<SpResult<UsuarioResult>> ObtenerPorCorreoAsync(LoginParameters request);
        Task<SpResult<UsuarioResult>> ObtenerPorIdAsync(int usuarioId);

        Task IncrementarIntentosFallidosAsync(int usuarioId);
        Task GuardarRefreshToken(RefreshToken refreshToken);
        Task<RefreshToken> ObtenerRefreshTokenAsync(string token);
        Task<SpResultBase> ConfirmarCuentaAsync(int userId);

        // --- Nuevos métodos para cambio de contraseña ---
        /// <summary>
        /// Actualiza el hash de contraseña del usuario.
        /// </summary>
        Task<SpResultBase> UpdatePasswordAsync(ChangePasswordParameters parameters);

        /// <summary>
        /// Resetea el contador de intentos fallidos tras un cambio exitoso de contraseña.
        /// </summary>
        Task<SpResultBase> ClearFailedAttemptsAsync(ClearFailedAttemptsParameters parameters);
        Task<SpResultBase> RevocarRefreshTokenAsync(LogoutParameters parameters);

        /// <summary>
        /// Registra un log de auditoría de cambio de contraseña (opcional).
        /// </summary>
        //Task LogPasswordChangeAsync(int usuarioId, string actor);
    }
}
