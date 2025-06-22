using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Empresa.Domain.TipoDirector.Repositories;
using Empresa.Domain.TipoDirector.Results;

namespace Empresa.Application.TipoDirector.UseCases
{
    public class ObtenerTipoDirectorPorIdUseCase : IUseCase<int, TipoDirectorResult?>
    {
        private readonly ITipoDirectorRepository _repository;

        public ObtenerTipoDirectorPorIdUseCase(ITipoDirectorRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, TipoDirectorResult?>> ExecuteAsync(int request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
