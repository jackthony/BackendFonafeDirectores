using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Empresa.Repositories;
using Empresa.Domain.Empresa.Results;

namespace Empresa.Application.Empresa.UseCases
{
    public class ObtenerEmpresaPorIdUseCase : IUseCase<int, EmpresaResult?>
    {
        private readonly IEmpresaRepository _repository;

        public ObtenerEmpresaPorIdUseCase(IEmpresaRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, EmpresaResult?>> ExecuteAsync(int request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
