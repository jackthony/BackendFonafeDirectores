using Director.Application.Dtos;
using Director.Application.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Director.Application.UseCases
{
    public class ObtenerDirectorPorIdUseCase : IUseCase<long, DirectorDto?>
    {
        private readonly IReadDirectorRepository _repository;

        public ObtenerDirectorPorIdUseCase(IReadDirectorRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, DirectorDto?>> ExecuteAsync(long request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
