using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Rubro.Repositories;
using Empresa.Domain.Rubro.Results;

namespace Empresa.Application.Rubro.UseCases
{
    public class ObtenerRubroPorIdUseCase : IUseCase<int, RubroResult?>
    {
        private readonly IRubroRepository _repository;

        public ObtenerRubroPorIdUseCase(IRubroRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, RubroResult?>> ExecuteAsync(int request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
