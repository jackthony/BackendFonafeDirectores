using Shared.Kernel.Responses;
using Empresa.Domain.Cargo.Parameters;
using Empresa.Domain.Cargo.Results;

namespace Empresa.Domain.Cargo.Repositories
{
    public interface ICargoRepository
    {
        public Task<SpResultBase> AddAsync(CrearCargoParameters request);
        public Task<SpResultBase> UpdateAsync(ActualizarCargoParameters request);
        public Task<SpResultBase> DeleteAsync(EliminarCargoParameters request);
        public Task<List<CargoResult>> ListAsync(ListarCargoParameters request);
        public Task<CargoResult?> GetByIdAsync(int id);
        public Task<PagedResult<CargoResult>> ListByPaginationAsync(ListarCargoPaginadoParameters request);
    }
}
