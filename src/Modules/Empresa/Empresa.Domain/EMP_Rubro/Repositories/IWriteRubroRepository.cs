using Empresa.Domain.EMP_Rubro.Models;
namespace Empresa.Domain.EMP_Rubro.Repositories
{
    public interface IWriteRubroRepository<T>
    {
        public Task<T> AddAsync(CrearRubroData request);
        public Task<T> UpdateAsync(ActualizarRubroData request);
        public Task<T> DeleteAsync(EliminarRubroData request);

    }
}
