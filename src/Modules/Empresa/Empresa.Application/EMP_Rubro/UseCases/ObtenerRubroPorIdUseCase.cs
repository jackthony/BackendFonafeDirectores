using Empresa.Application.EMP_Rubro.Dtos;
using Empresa.Application.EMP_Rubro.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Empresa.Application.EMP_Rubro.UseCases
{
    public class ObtenerRubroPorIdUseCase : IUseCase<long, RubroDto?>
    {
        private readonly IReadRubroRepository _repository;

        public ObtenerRubroPorIdUseCase(IReadRubroRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, RubroDto?>> ExecuteAsync(long request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
