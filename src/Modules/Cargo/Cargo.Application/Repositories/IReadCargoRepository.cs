using Cargo.Application.Dtos;
using Cargo.Domain.Models;
using Shared.Kernel.Responses;

namespace Cargo.Application.Repositories
{
    public interface IReadCargoRepository
    {
        Task<List<CargoDto>> ListAsync(ListarCargoRequest request);
        Task<CargoDto?> GetByIdAsync(long id);
        Task<PagedResult<CargoDto>> ListByPaginationAsync(ListarCargoPaginadoRequest request);
    }
}
