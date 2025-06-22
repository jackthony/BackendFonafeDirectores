using Empresa.Application.EMP_Sector.Dtos;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Sector.Repositories
{
    public interface IReadSectorRepository
    {
        Task<List<SectorDto>> ListAsync(ListarSectorRequest request);
        Task<SectorDto?> GetByIdAsync(long id);
        Task<PagedResult<SectorDto>> ListByPaginationAsync(ListarSectorPaginadoRequest request);
    }
}
