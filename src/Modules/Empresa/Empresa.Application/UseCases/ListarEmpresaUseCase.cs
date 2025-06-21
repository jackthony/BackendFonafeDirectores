using Empresa.Application.Dtos;
using Empresa.Application.Repositories;
using Empresa.Domain.Models;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Empresa.Application.UseCases
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
