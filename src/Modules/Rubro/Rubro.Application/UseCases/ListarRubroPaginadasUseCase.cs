using Rubro.Application.Dtos;
using Rubro.Application.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Rubro.Application.UseCases
{
    public class ListarRubroPaginadasUseCase : IUseCase<ListarRubroPaginadoRequest, PagedResult<RubroDto>>
    {
        private readonly IReadRubroRepository _repository;

        public ListarRubroPaginadasUseCase(IReadRubroRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, PagedResult<RubroDto>>> ExecuteAsync(ListarRubroPaginadoRequest request)
        {
            var result = await _repository.ListByPaginationAsync(request);
            return result;
        }
    }
}
