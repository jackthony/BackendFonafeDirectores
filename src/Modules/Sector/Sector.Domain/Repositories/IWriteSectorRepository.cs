using Sector.Domain.Models;

namespace Sector.Domain.Repositories
{
    public interface IWriteSectorRepository<T>
    {
        public Task<T> AddAsync(CrearSectorData request);
        public Task<T> UpdateAsync(ActualizarSectorData request);
        public Task<T> DeleteAsync(EliminarSectorData request);
    }
}
