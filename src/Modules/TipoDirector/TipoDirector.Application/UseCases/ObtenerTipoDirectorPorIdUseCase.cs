using TipoDirector.Application.Dtos;
using TipoDirector.Application.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace TipoDirector.Application.UseCases
{
    public class ObtenerTipoDirectorPorIdUseCase : IUseCase<long, TipoDirectorDto?>
    {
        private readonly IReadTipoDirectorRepository _repository;

        public ObtenerTipoDirectorPorIdUseCase(IReadTipoDirectorRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, TipoDirectorDto?>> ExecuteAsync(long request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
