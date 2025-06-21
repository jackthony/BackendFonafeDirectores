using Empresa.Application.Dtos;
using Empresa.Domain.Models;
using Shared.Kernel.Responses;

namespace Empresa.Application.Repositories
{
    public interface IReadEmpresaRepository
    {
        Task<List<EmpresaDto>> ListAsync(ListarEmpresaRequest request);
        Task<EmpresaDto?> GetByIdAsync(long id);
        Task<PagedResult<EmpresaDto>> ListByPaginationAsync(ListarEmpresaPaginadoRequest request);
    }
}
