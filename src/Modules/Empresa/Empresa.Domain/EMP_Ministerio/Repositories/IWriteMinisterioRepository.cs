using Empresa.Domain.EMP_Ministerio.Models;

namespace Empresa.Domain.EMP_Ministerio.Repositories
{
    public interface IWriteMinisterioRepository<T>
    {
        public Task<T> AddAsync(CrearMinisterioData request);
        public Task<T> UpdateAsync(ActualizarMinisterioData request);
        public Task<T> DeleteAsync(EliminarMinisterioData request);
    }
}
