using Shared.Kernel.Responses;
using Empresa.Domain.Ministerio.Parameters;
using Empresa.Domain.Ministerio.Results;

namespace Empresa.Domain.Ministerio.Repositories
{
    public interface IMinisterioRepository
    {
        public Task<SpResultBase> AddAsync(CrearMinisterioParameters request);
        public Task<SpResultBase> UpdateAsync(ActualizarMinisterioParameters request);
        public Task<SpResultBase> DeleteAsync(EliminarMinisterioParameters request);
        public Task<List<MinisterioResult>> ListAsync(ListarMinisterioParameters request);
        public Task<MinisterioResult?> GetByIdAsync(int id);
        public Task<PagedResult<MinisterioResult>> ListByPaginationAsync(ListarMinisterioPaginadoParameters request);
    }
}
