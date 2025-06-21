using Modulo.Application.Dtos;
using Modulo.Application.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Modulo.Application.UseCases
{
    public class ListarModuloPaginadasUseCase : IUseCase<ListarModuloPaginadoRequest, PagedResult<ModuloDto>>
    {
        private readonly IReadModuloRepository _repository;

        public ListarModuloPaginadasUseCase(IReadModuloRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, PagedResult<ModuloDto>>> ExecuteAsync(ListarModuloPaginadoRequest request)
        {
            var result = await _repository.ListByPaginationAsync(request);
            return result;
        }
    }
}
