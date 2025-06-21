using Empresa.Application.Dtos;
using Empresa.Application.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Empresa.Application.UseCases
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
