using Shared.Kernel.Responses;
using Usuario.Domain.Auth.Parameters;
using Usuario.Domain.Auth.Results;

namespace Usuario.Domain.Auth.Repositories
{
    public interface IAuthRepository
    {
        public Task<SpResult<UsuarioResult>> ObtenerPorCorreoAsync(LoginParameters request);
        public Task<SpResult<UsuarioResult>> ObtenerPorIdAsync(int usuarioId);
    }
}
