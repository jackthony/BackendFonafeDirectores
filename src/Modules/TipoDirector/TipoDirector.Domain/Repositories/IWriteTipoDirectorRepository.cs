using TipoDirector.Domain.Models;

namespace TipoDirector.Domain.Repositories
{
    public interface IWriteTipoDirectorRepository<T>
    {
        public Task<T> AddAsync(CrearTipoDirectorData request);
        public Task<T> UpdateAsync(ActualizarTipoDirectorData request);
        public Task<T> DeleteAsync(EliminarTipoDirectorData request);
    }
}
