using Shared.Kernel.Responses;
using Empresa.Domain.Especialidad.Parameters;
using Empresa.Domain.Especialidad.Results;

namespace Empresa.Domain.Especialidad.Repositories
{
    public interface IEspecialidadRepository
    {
        public Task<SpResultBase> AddAsync(CrearEspecialidadParameters request);
        public Task<SpResultBase> UpdateAsync(ActualizarEspecialidadParameters request);
        public Task<SpResultBase> DeleteAsync(EliminarEspecialidadParameters request);
        public Task<List<EspecialidadResult>> ListAsync(ListarEspecialidadParameters request);
        public Task<EspecialidadResult?> GetByIdAsync(int id);
        public Task<PagedResult<EspecialidadResult>> ListByPaginationAsync(ListarEspecialidadPaginadoParameters request);
    }
}
