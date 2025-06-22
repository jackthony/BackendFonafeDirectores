using Empresa.Application.EMP_Empresa.Dtos;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Empresa.Repositories
{
    public interface IReadEmpresaRepository
    {
        Task<List<EmpresaDto>> ListAsync(ListarEmpresaRequest request);
        Task<EmpresaDto?> GetByIdAsync(long id);
        Task<PagedResult<EmpresaDto>> ListByPaginationAsync(ListarEmpresaPaginadoRequest request);
    }
}
