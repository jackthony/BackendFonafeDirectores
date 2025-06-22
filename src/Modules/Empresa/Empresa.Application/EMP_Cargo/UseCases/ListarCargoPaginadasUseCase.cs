using Empresa.Application.EMP_Cargo.Dtos;
using Empresa.Application.EMP_Cargo.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Cargo.UseCases
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
