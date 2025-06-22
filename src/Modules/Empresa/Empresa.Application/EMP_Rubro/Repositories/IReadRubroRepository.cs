using Empresa.Application.EMP_Rubro.Dtos;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Rubro.Repositories
{
    public interface IReadRubroRepository
    {
        Task<List<RubroDto>> ListAsync(ListarRubroRequest request);
        Task<RubroDto?> GetByIdAsync(long id);
        Task<PagedResult<RubroDto>> ListByPaginationAsync(ListarRubroPaginadoRequest request);
    }
}
