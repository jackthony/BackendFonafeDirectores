using Modulo.Application.Dtos;
using Modulo.Domain.Models;
using Shared.Kernel.Responses;

namespace Modulo.Application.Repositories
{
    public interface IReadModuloRepository
    {
        Task<List<ModuloDto>> ListAsync(ListarModuloRequest request);
        Task<ModuloDto?> GetByIdAsync(long id);
        Task<PagedResult<ModuloDto>> ListByPaginationAsync(ListarModuloPaginadoRequest request);
    }
}
