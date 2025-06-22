using Empresa.Application.EMP_Especialidad.Dtos;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Especialidad.Repositories
{
    public interface IReadEspecialidadRepository
    {
        Task<List<EspecialidadDto>> ListAsync(ListarEspecialidadRequest request);
        Task<EspecialidadDto?> GetByIdAsync(long id);
        Task<PagedResult<EspecialidadDto>> ListByPaginationAsync(ListarEspecialidadPaginadoRequest request);
    }
}
