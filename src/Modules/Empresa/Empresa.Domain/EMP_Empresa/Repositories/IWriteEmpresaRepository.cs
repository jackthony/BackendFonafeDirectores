using Empresa.Domain.EMP_Empresa.Models;

namespace Empresa.Domain.EMP_Empresa.Repositories
{
    public interface IWriteEmpresaRepository<T>
    {
        public Task<T> AddAsync(CrearEmpresaData request);
        public Task<T> UpdateAsync(ActualizarEmpresaData request);
        public Task<T> DeleteAsync(EliminarEmpresaData request);
    }
}
