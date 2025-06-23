using Shared.Kernel.Responses;
using Empresa.Domain.Ubigeo.Parameters;
using Empresa.Domain.Ubigeo.Results;

namespace Empresa.Domain.Ubigeo.Repositories
{
    public interface IUbigeoRepository
    {
        public Task<SpResultBase> AddAsync(CrearUbigeoParameters request);
        public Task<SpResultBase> UpdateAsync(ActualizarUbigeoParameters request);
        public Task<SpResultBase> DeleteAsync(EliminarUbigeoParameters request);
        public Task<List<UbigeoResult>> ListAsync(ListarUbigeoParameters request);
        public Task<UbigeoResult?> GetByIdAsync(int id);
        public Task<PagedResult<UbigeoResult>> ListByPaginationAsync(ListarUbigeoPaginadoParameters request);
    }
}
