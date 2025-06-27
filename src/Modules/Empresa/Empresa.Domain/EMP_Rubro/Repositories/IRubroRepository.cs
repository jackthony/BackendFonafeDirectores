using Shared.Kernel.Responses;
using Empresa.Domain.Rubro.Parameters;
using Empresa.Domain.Rubro.Results;

namespace Empresa.Domain.Rubro.Repositories
{
    public interface IRubroRepository
    {
        public Task<SpResultBase> AddAsync(CrearRubroParameters request);
        public Task<SpResultBase> UpdateAsync(ActualizarRubroParameters request);
        public Task<SpResultBase> DeleteAsync(EliminarRubroParameters request);
        public Task<List<RubroResult>> ListAsync(ListarRubroParameters request);
        public Task<RubroResult?> GetByIdAsync(int id);
        public Task<PagedResult<RubroResult>> ListByPaginationAsync(ListarRubroPaginadoParameters request);
    }
}
