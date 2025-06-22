using Empresa.Application.EMP_TipoDirector.Dtos;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_TipoDirector.Repositories
{
    public interface IReadTipoDirectorRepository
    {
        Task<List<TipoDirectorDto>> ListAsync(ListarTipoDirectorRequest request);
        Task<TipoDirectorDto?> GetByIdAsync(long id);
        Task<PagedResult<TipoDirectorDto>> ListByPaginationAsync(ListarTipoDirectorPaginadoRequest request);
    }
}
