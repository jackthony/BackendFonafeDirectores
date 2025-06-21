using Modulo.Domain.Models;

namespace Modulo.Domain.Repositories
{
    public interface IWriteModuloRepository<T>
    {
        public Task<T> AddAsync(CrearModuloData request);
        public Task<T> UpdateAsync(ActualizarModuloData request);
        public Task<T> DeleteAsync(EliminarModuloData request);
    }
}
