using Ministerio.Application.Dtos;
using Ministerio.Application.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Ministerio.Application.UseCases
{
    public class ObtenerMinisterioPorIdUseCase : IUseCase<long, MinisterioDto?>
    {
        private readonly IReadMinisterioRepository _repository;

        public ObtenerMinisterioPorIdUseCase(IReadMinisterioRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, MinisterioDto?>> ExecuteAsync(long request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
