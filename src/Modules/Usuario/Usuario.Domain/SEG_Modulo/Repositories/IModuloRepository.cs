using Shared.Kernel.Responses;
using Usuario.Domain.Modulo.Parameters;
using Usuario.Domain.Modulo.Results;

namespace Usuario.Domain.Modulo.Repositories
{
    public interface IModuloRepository
    {
        public Task<SpResultBase> AddAsync(CrearModuloParameters request);
        public Task<SpResultBase> UpdateAsync(ActualizarModuloParameters request);
        public Task<SpResultBase> DeleteAsync(EliminarModuloParameters request);
        public Task<List<ModuloResult>> ListAsync(ListarModuloParameters request);
        public Task<ModuloResult?> GetByIdAsync(int id);
        public Task<PagedResult<ModuloResult>> ListByPaginationAsync(ListarModuloPaginadoParameters request);
        public Task<List<ModuloConAccionesResult>> ListModulosWithAccionsAsync(int rolId);
    }
}
