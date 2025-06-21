using Ministerio.Application.Dtos;
using Ministerio.Domain.Models;
using Shared.Kernel.Responses;

namespace Ministerio.Application.Repositories
{
    public interface IReadMinisterioRepository
    {
        Task<List<MinisterioDto>> ListAsync(ListarMinisterioRequest request);
        Task<MinisterioDto?> GetByIdAsync(long id);
        Task<PagedResult<MinisterioDto>> ListByPaginationAsync(ListarMinisterioPaginadoRequest request);
    }
}
