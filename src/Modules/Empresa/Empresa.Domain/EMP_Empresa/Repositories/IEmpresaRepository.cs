using Shared.Kernel.Responses;
using Empresa.Domain.Empresa.Parameters;
using Empresa.Domain.Empresa.Results;

namespace Empresa.Domain.Empresa.Repositories
{
    public interface IEmpresaRepository
    {
        public Task<SpResultBase> AddAsync(CrearEmpresaParameters request);
        public Task<SpResultBase> UpdateAsync(ActualizarEmpresaParameters request);
        public Task<SpResultBase> DeleteAsync(EliminarEmpresaParameters request);
        public Task<List<EmpresaResult>> ListAsync(ListarEmpresaParameters request);
        public Task<EmpresaResult?> GetByIdAsync(int id);
        public Task<PagedResult<EmpresaResult>> ListByPaginationAsync(ListarEmpresaPaginadoParameters request);
    }
}
