using Ministerio.Domain.Models;

namespace Ministerio.Domain.Repositories
{
    public interface IWriteMinisterioRepository<T>
    {
        public Task<T> AddAsync(CrearMinisterioData request);
        public Task<T> UpdateAsync(ActualizarMinisterioData request);
        public Task<T> DeleteAsync(EliminarMinisterioData request);
    }
}
