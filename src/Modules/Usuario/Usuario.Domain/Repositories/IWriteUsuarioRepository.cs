using Usuario.Domain.Models;

namespace Usuario.Domain.Repositories
{
    public interface IWriteUsuarioRepository<T>
    {
        public Task<T> AddAsync(CrearUsuarioData request);
        public Task<T> UpdateAsync(ActualizarUsuarioData request);
        public Task<T> DeleteAsync(EliminarUsuarioData request);
    }
}
