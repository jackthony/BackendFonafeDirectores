using Sector.Application.Dtos;
using Sector.Domain.Models;
using Shared.Kernel.Responses;

namespace Sector.Application.Repositories
{
    public interface IReadSectorRepository
    {
        Task<List<SectorDto>> ListAsync(ListarSectorRequest request);
        Task<SectorDto?> GetByIdAsync(long id);
        Task<PagedResult<SectorDto>> ListByPaginationAsync(ListarSectorPaginadoRequest request);
    }
}
