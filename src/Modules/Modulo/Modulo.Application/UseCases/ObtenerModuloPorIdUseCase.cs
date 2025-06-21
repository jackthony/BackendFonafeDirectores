using Modulo.Application.Dtos;
using Modulo.Application.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Modulo.Application.UseCases
{
    public class ObtenerModuloPorIdUseCase : IUseCase<long, ModuloDto?>
    {
        private readonly IReadModuloRepository _repository;

        public ObtenerModuloPorIdUseCase(IReadModuloRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, ModuloDto?>> ExecuteAsync(long request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
