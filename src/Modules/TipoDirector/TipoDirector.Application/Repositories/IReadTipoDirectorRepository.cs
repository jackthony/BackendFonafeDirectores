using TipoDirector.Application.Dtos;
using TipoDirector.Domain.Models;
using Shared.Kernel.Responses;

namespace TipoDirector.Application.Repositories
{
    public interface IReadTipoDirectorRepository
    {
        Task<List<TipoDirectorDto>> ListAsync(ListarTipoDirectorRequest request);
        Task<TipoDirectorDto?> GetByIdAsync(long id);
        Task<PagedResult<TipoDirectorDto>> ListByPaginationAsync(ListarTipoDirectorPaginadoRequest request);
    }
}
