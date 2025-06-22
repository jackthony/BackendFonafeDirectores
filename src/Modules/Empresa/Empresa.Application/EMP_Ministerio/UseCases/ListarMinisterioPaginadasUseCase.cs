using Empresa.Application.EMP_Ministerio.Dtos;
using Empresa.Application.EMP_Ministerio.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Ministerio.UseCases
{
    public class ListarMinisterioPaginadasUseCase : IUseCase<ListarMinisterioPaginadoRequest, PagedResult<MinisterioDto>>
    {
        private readonly IReadMinisterioRepository _repository;

        public ListarMinisterioPaginadasUseCase(IReadMinisterioRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, PagedResult<MinisterioDto>>> ExecuteAsync(ListarMinisterioPaginadoRequest request)
        {
            var result = await _repository.ListByPaginationAsync(request);
            return result;
        }
    }
}
