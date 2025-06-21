using Accion.Application.Dtos;
using Accion.Application.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Accion.Application.UseCases
{
    public class ListarAccionPaginadasUseCase : IUseCase<ListarAccionPaginadoRequest, PagedResult<AccionDto>>
    {
        private readonly IReadAccionRepository _repository;

        public ListarAccionPaginadasUseCase(IReadAccionRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, PagedResult<AccionDto>>> ExecuteAsync(ListarAccionPaginadoRequest request)
        {
            var result = await _repository.ListByPaginationAsync(request);
            return result;
        }
    }
}
