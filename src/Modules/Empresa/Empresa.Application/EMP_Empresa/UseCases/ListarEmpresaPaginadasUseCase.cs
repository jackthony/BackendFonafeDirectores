using Empresa.Application.EMP_Empresa.Dtos;
using Empresa.Application.EMP_Empresa.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Empresa.UseCases
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
