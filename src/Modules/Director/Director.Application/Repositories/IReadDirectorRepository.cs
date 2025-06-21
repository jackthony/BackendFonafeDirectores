using Director.Application.Dtos;
using Director.Domain.Models;
using Shared.Kernel.Responses;

namespace Director.Application.Repositories
{
    public interface IReadDirectorRepository
    {
        Task<List<DirectorDto>> ListAsync(ListarDirectorRequest request);
        Task<DirectorDto?> GetByIdAsync(long id);
        Task<PagedResult<DirectorDto>> ListByPaginationAsync(ListarDirectorPaginadoRequest request);
    }
}
