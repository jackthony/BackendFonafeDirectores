using Rol.Application.Dtos;
using Rol.Domain.Models;
using Shared.Kernel.Responses;

namespace Rol.Application.Repositories
{
    public interface IReadRolRepository
    {
        Task<List<RolDto>> ListAsync(ListarRolRequest request);
        Task<RolDto?> GetByIdAsync(long id);
        Task<PagedResult<RolDto>> ListByPaginationAsync(ListarRolPaginadoRequest request);
    }
}
