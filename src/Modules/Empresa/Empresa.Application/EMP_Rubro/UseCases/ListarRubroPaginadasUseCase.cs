using Empresa.Application.EMP_Rubro.Dtos;
using Empresa.Application.EMP_Rubro.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Rubro.UseCases
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
