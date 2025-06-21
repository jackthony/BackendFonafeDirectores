using Director.Application.Dtos;
using Director.Application.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Director.Application.UseCases
{
    public class ListarDirectorPaginadasUseCase : IUseCase<ListarDirectorPaginadoRequest, PagedResult<DirectorDto>>
    {
        private readonly IReadDirectorRepository _repository;

        public ListarDirectorPaginadasUseCase(IReadDirectorRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, PagedResult<DirectorDto>>> ExecuteAsync(ListarDirectorPaginadoRequest request)
        {
            var result = await _repository.ListByPaginationAsync(request);
            return result;
        }
    }
}
