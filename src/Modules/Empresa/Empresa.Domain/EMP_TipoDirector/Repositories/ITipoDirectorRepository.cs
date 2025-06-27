using Shared.Kernel.Responses;
using Empresa.Domain.TipoDirector.Parameters;
using Empresa.Domain.TipoDirector.Results;

namespace Empresa.Domain.TipoDirector.Repositories
{
    public interface ITipoDirectorRepository
    {
        public Task<SpResultBase> AddAsync(CrearTipoDirectorParameters request);
        public Task<SpResultBase> UpdateAsync(ActualizarTipoDirectorParameters request);
        public Task<SpResultBase> DeleteAsync(EliminarTipoDirectorParameters request);
        public Task<List<TipoDirectorResult>> ListAsync(ListarTipoDirectorParameters request);
        public Task<TipoDirectorResult?> GetByIdAsync(int id);
        public Task<PagedResult<TipoDirectorResult>> ListByPaginationAsync(ListarTipoDirectorPaginadoParameters request);
    }
}
