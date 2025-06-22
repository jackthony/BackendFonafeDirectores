using Empresa.Application.EMP_Ministerio.Dtos;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Ministerio.Repositories
{
    public interface IReadMinisterioRepository
    {
        Task<List<MinisterioDto>> ListAsync(ListarMinisterioRequest request);
        Task<MinisterioDto?> GetByIdAsync(long id);
        Task<PagedResult<MinisterioDto>> ListByPaginationAsync(ListarMinisterioPaginadoRequest request);
    }
}
