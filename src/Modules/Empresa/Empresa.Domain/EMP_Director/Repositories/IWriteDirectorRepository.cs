using Empresa.Domain.EMP_Director.Models;

namespace Empresa.Domain.EMP_Director.Repositories
{
    public interface IWriteDirectorRepository<T>
    {
        public Task<T> AddAsync(CrearDirectorData request);
        public Task<T> UpdateAsync(ActualizarDirectorData request);
        public Task<T> DeleteAsync(EliminarDirectorData request);
    }
}
