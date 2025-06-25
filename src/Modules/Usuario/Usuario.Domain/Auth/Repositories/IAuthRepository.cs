using Shared.Kernel.Responses;
using Usuario.Domain.Auth.Parameters;
using Usuario.Domain.Auth.Results;

namespace Usuario.Domain.Auth.Repositories
{
    public interface IAuthRepository
    {
        Task<SpResult<UsuarioResult>> ObtenerPorCorreoAsync(LoginParameters request);
        Task<SpResult<UsuarioResult>> ObtenerPorIdAsync(int usuarioId);

        Task IncrementarIntentosFallidosAsync(int usuarioId);
        Task ResetearIntentosFallidosAsync(int usuarioId);
    }
}
