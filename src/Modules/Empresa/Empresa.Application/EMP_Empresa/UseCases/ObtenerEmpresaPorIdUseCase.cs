using Empresa.Application.EMP_Empresa.Dtos;
using Empresa.Application.EMP_Empresa.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Empresa.Application.EMP_Empresa.UseCases
{
    public class ObtenerEmpresaPorIdUseCase : IUseCase<long, EmpresaDto?>
    {
        private readonly IReadEmpresaRepository _repository;

        public ObtenerEmpresaPorIdUseCase(IReadEmpresaRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, EmpresaDto?>> ExecuteAsync(long request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
