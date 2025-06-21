using Usuario.Application.Dtos;
using Usuario.Domain.Models;
using Shared.Kernel.Responses;

namespace Usuario.Application.Repositories
{
    public interface IReadUsuarioRepository
    {
        Task<List<UsuarioDto>> ListAsync(ListarUsuarioRequest request);
        Task<UsuarioDto?> GetByIdAsync(long id);
        Task<PagedResult<UsuarioDto>> ListByPaginationAsync(ListarUsuarioPaginadoRequest request);
    }
}
