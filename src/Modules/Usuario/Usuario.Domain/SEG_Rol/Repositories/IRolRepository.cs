using Shared.Kernel.Responses;
using Usuario.Domain.Rol.Parameters;
using Usuario.Domain.Rol.Results;

namespace Usuario.Domain.Rol.Repositories
{
    public interface IRolRepository
    {
        public Task<SpResultBase> AddAsync(CrearRolParameters request);
        public Task<SpResultBase> UpdateAsync(ActualizarRolParameters request);
        public Task<SpResultBase> DeleteAsync(EliminarRolParameters request);
        public Task<List<RolResult>> ListAsync(ListarRolParameters request);
        public Task<RolResult?> GetByIdAsync(int id);
        public Task<PagedResult<RolResult>> ListByPaginationAsync(ListarRolPaginadoParameters request);
    }
}
