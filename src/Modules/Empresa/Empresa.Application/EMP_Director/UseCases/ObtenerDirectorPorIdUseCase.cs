using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Director.Repositories;
using Empresa.Domain.Director.Results;

namespace Empresa.Application.Director.UseCases
{
    public class ObtenerDirectorPorIdUseCase : IUseCase<int, DirectorResult?>
    {
        private readonly IDirectorRepository _repository;

        public ObtenerDirectorPorIdUseCase(IDirectorRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, DirectorResult?>> ExecuteAsync(int request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
