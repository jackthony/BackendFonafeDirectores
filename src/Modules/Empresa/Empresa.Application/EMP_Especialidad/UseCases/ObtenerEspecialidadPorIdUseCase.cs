using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Especialidad.Repositories;
using Empresa.Domain.Especialidad.Results;

namespace Empresa.Application.Especialidad.UseCases
{
    public class ObtenerEspecialidadPorIdUseCase : IUseCase<int, EspecialidadResult?>
    {
        private readonly IEspecialidadRepository _repository;

        public ObtenerEspecialidadPorIdUseCase(IEspecialidadRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, EspecialidadResult?>> ExecuteAsync(int request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
