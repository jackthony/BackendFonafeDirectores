using Shared.Kernel.Responses;
using Usuario.Domain.PermisoRol.Parameters;
using Usuario.Domain.PermisoRol.Results;

namespace Usuario.Domain.PermisoRol.Repositories
{
    public interface IPermisoRolRepository
    {
        public Task<SpResultBase> AddAsync(CrearPermisoRolParameters request);
        public Task<SpResultBase> UpdateAsync(ActualizarPermisoRolParameters request);
        public Task<SpResultBase> DeleteAsync(EliminarPermisoRolParameters request);
        public Task<List<PermisoRolResult>> ListAsync(ListarPermisoRolParameters request);
        public Task<PermisoRolResult?> GetByIdAsync(int id);
        public Task<PagedResult<PermisoRolResult>> ListByPaginationAsync(ListarPermisoRolPaginadoParameters request);
    }
}
