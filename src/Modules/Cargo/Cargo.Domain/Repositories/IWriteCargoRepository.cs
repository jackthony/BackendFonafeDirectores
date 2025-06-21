using Cargo.Domain.Models;

namespace Cargo.Domain.Repositories
{
    public interface IWriteCargoRepository<T>
    {
        public Task<T> AddAsync(CrearCargoData request);
        public Task<T> UpdateAsync(ActualizarCargoData request);
        public Task<T> DeleteAsync(EliminarCargoData request);
    }
}
