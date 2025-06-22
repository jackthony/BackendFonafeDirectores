using Empresa.Domain.EMP_Especialidad.Models;

namespace Empresa.Domain.EMP_Especialidad.Repositories
{
    public interface IWriteEspecialidadRepository<T>
    {
        public Task<T> AddAsync(CrearEspecialidadData request);
        public Task<T> UpdateAsync(ActualizarEspecialidadData request);
        public Task<T> DeleteAsync(EliminarEspecialidadData request);
    }
}
