using TipoDirector.Application.Dtos;
using TipoDirector.Application.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace TipoDirector.Application.UseCases
{
    public class ListarTipoDirectorPaginadasUseCase : IUseCase<ListarTipoDirectorPaginadoRequest, PagedResult<TipoDirectorDto>>
    {
        private readonly IReadTipoDirectorRepository _repository;

        public ListarTipoDirectorPaginadasUseCase(IReadTipoDirectorRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, PagedResult<TipoDirectorDto>>> ExecuteAsync(ListarTipoDirectorPaginadoRequest request)
        {
            var result = await _repository.ListByPaginationAsync(request);
            return result;
        }
    }
}
