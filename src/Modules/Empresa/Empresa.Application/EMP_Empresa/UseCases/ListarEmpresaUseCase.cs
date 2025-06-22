using Empresa.Application.EMP_Empresa.Dtos;
using Empresa.Application.EMP_Empresa.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Empresa.Application.EMP_Empresa.UseCases
{
    public class ListarEmpresaUseCase : IUseCase<ListarEmpresaRequest, List<EmpresaDto>>
    {
        private readonly IReadEmpresaRepository _repository;

        public ListarEmpresaUseCase(IReadEmpresaRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, List<EmpresaDto>>> ExecuteAsync(ListarEmpresaRequest request)
        {
            var result = await _repository.ListAsync(request);
            return result;
        }
    }
}
