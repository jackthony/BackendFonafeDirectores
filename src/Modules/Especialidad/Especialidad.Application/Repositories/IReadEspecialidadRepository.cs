using Especialidad.Application.Dtos;
using Especialidad.Domain.Models;
using Shared.Kernel.Responses;

namespace Especialidad.Application.Repositories
{
    public interface IReadEspecialidadRepository
    {
        Task<List<EspecialidadDto>> ListAsync(ListarEspecialidadRequest request);
        Task<EspecialidadDto?> GetByIdAsync(long id);
        Task<PagedResult<EspecialidadDto>> ListByPaginationAsync(ListarEspecialidadPaginadoRequest request);
    }
}
