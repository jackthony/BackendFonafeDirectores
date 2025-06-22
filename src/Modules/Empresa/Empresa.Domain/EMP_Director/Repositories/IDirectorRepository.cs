using Shared.Kernel.Responses;
using Empresa.Domain.Director.Parameters;
using Empresa.Domain.Director.Results;

namespace Empresa.Domain.Director.Repositories
{
    public interface IDirectorRepository
    {
        public Task<SpResultBase> AddAsync(CrearDirectorParameters request);
        public Task<SpResultBase> UpdateAsync(ActualizarDirectorParameters request);
        public Task<SpResultBase> DeleteAsync(EliminarDirectorParameters request);
        public Task<List<DirectorResult>> ListAsync(ListarDirectorParameters request);
        public Task<DirectorResult?> GetByIdAsync(int id);
        public Task<PagedResult<DirectorResult>> ListByPaginationAsync(ListarDirectorPaginadoParameters request);
    }
}
