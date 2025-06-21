using Especialidad.Domain.Models;

namespace Especialidad.Domain.Repositories
{
    public interface IWriteEspecialidadRepository<T>
    {
        public Task<T> AddAsync(CrearEspecialidadData request);
        public Task<T> UpdateAsync(ActualizarEspecialidadData request);
        public Task<T> DeleteAsync(EliminarEspecialidadData request);
    }
}
