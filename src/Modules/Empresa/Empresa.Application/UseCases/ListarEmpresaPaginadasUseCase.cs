using Empresa.Application.Dtos;
using Empresa.Application.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.UseCases
{
    public class ListarEmpresaPaginadasUseCase : IUseCase<ListarEmpresaPaginadoRequest, PagedResult<EmpresaDto>>
    {
        private readonly IReadEmpresaRepository _repository;

        public ListarEmpresaPaginadasUseCase(IReadEmpresaRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, PagedResult<EmpresaDto>>> ExecuteAsync(ListarEmpresaPaginadoRequest request)
        {
            var result = await _repository.ListByPaginationAsync(request);
            return result;
        }
    }
}
