using Accion.Application.Dtos;
using Accion.Domain.Models;
using Shared.Kernel.Responses;

namespace Accion.Application.Repositories
{
    public interface IReadAccionRepository
    {
        Task<List<AccionDto>> ListAsync(ListarAccionRequest request);
        Task<AccionDto?> GetByIdAsync(long id);
        Task<PagedResult<AccionDto>> ListByPaginationAsync(ListarAccionPaginadoRequest request);
    }
}
