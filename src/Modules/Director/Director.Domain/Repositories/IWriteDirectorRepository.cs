using Director.Domain.Models;

namespace Director.Domain.Repositories
{
    public interface IWriteDirectorRepository<T>
    {
        public Task<T> AddAsync(CrearDirectorData request);
        public Task<T> UpdateAsync(ActualizarDirectorData request);
        public Task<T> DeleteAsync(EliminarDirectorData request);
    }
}
