using Empresa.Domain.EMP_Cargo.Models;

namespace Empresa.Domain.EMP_Cargo.Repositories
{
    public interface IWriteCargoRepository<T>
    {
        public Task<T> AddAsync(CrearCargoData request);
        public Task<T> UpdateAsync(ActualizarCargoData request);
        public Task<T> DeleteAsync(EliminarCargoData request);
    }
}
