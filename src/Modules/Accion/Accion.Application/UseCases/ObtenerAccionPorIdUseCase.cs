using Accion.Application.Dtos;
using Accion.Application.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Accion.Application.UseCases
{
    public class ObtenerAccionPorIdUseCase : IUseCase<long, AccionDto?>
    {
        private readonly IReadAccionRepository _repository;

        public ObtenerAccionPorIdUseCase(IReadAccionRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, AccionDto?>> ExecuteAsync(long request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
