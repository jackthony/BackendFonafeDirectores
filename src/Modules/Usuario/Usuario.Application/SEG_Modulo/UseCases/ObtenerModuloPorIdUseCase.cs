using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Usuario.Domain.Modulo.Repositories;
using Usuario.Domain.Modulo.Results;

namespace Usuario.Application.Modulo.UseCases
{
    public class ObtenerModuloPorIdUseCase : IUseCase<int, ModuloResult?>
    {
        private readonly IModuloRepository _repository;

        public ObtenerModuloPorIdUseCase(IModuloRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, ModuloResult?>> ExecuteAsync(int request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
