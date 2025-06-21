using Accion.Domain.Models;

namespace Accion.Domain.Repositories
{
    public interface IWriteAccionRepository<T>
    {
        public Task<T> AddAsync(CrearAccionData request);
        public Task<T> UpdateAsync(ActualizarAccionData request);
        public Task<T> DeleteAsync(EliminarAccionData request);
    }
}
