using Cargo.Application.Dtos;
using Cargo.Application.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Cargo.Application.UseCases
{
    public class ListarCargoPaginadasUseCase : IUseCase<ListarCargoPaginadoRequest, PagedResult<CargoDto>>
    {
        private readonly IReadCargoRepository _repository;

        public ListarCargoPaginadasUseCase(IReadCargoRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, PagedResult<CargoDto>>> ExecuteAsync(ListarCargoPaginadoRequest request)
        {
            var result = await _repository.ListByPaginationAsync(request);
            return result;
        }
    }
}
