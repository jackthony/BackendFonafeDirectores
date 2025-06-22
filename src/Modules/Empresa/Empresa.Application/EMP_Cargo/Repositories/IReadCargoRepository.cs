using Empresa.Application.EMP_Cargo.Dtos;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Cargo.Repositories
{
    public interface IReadCargoRepository
    {
        Task<List<CargoDto>> ListAsync(ListarCargoRequest request);
        Task<CargoDto?> GetByIdAsync(long id);
        Task<PagedResult<CargoDto>> ListByPaginationAsync(ListarCargoPaginadoRequest request);
    }
}
