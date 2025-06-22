using Shared.Kernel.Responses;
using Empresa.Domain.Sector.Parameters;
using Empresa.Domain.Sector.Results;

namespace Empresa.Domain.Sector.Repositories
{
    public interface ISectorRepository
    {
        public Task<SpResultBase> AddAsync(CrearSectorParameters request);
        public Task<SpResultBase> UpdateAsync(ActualizarSectorParameters request);
        public Task<SpResultBase> DeleteAsync(EliminarSectorParameters request);
        public Task<List<SectorResult>> ListAsync(ListarSectorParameters request);
        public Task<SectorResult?> GetByIdAsync(int id);
        public Task<PagedResult<SectorResult>> ListByPaginationAsync(ListarSectorPaginadoParameters request);
    }
}
