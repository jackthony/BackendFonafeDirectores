using Rubro.Application.Dtos;
using Rubro.Domain.Models;
using Shared.Kernel.Responses;

namespace Rubro.Application.Repositories
{
    public interface IReadRubroRepository
    {
        Task<List<RubroDto>> ListAsync(ListarRubroRequest request);
        Task<RubroDto?> GetByIdAsync(long id);
        Task<PagedResult<RubroDto>> ListByPaginationAsync(ListarRubroPaginadoRequest request);
    }
}
