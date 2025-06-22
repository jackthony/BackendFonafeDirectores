using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Ministerio.Repositories;
using Empresa.Domain.Ministerio.Results;

namespace Empresa.Application.Ministerio.UseCases
{
    public class ObtenerMinisterioPorIdUseCase : IUseCase<int, MinisterioResult?>
    {
        private readonly IMinisterioRepository _repository;

        public ObtenerMinisterioPorIdUseCase(IMinisterioRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, MinisterioResult?>> ExecuteAsync(int request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
