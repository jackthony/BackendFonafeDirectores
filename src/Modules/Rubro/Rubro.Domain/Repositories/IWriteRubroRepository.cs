using Rubro.Domain.Models;

namespace Rubro.Domain.Repositories
{
    public interface IWriteRubroRepository<T>
    {
        public Task<T> AddAsync(CrearRubroData request);
        public Task<T> UpdateAsync(ActualizarRubroData request);
        public Task<T> DeleteAsync(EliminarRubroData request);
    }
}
