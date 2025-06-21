using Rol.Domain.Models;

namespace Rol.Domain.Repositories
{
    public interface IWriteRolRepository<T>
    {
        public Task<T> AddAsync(CrearRolData request);
        public Task<T> UpdateAsync(ActualizarRolData request);
        public Task<T> DeleteAsync(EliminarRolData request);
    }
}
