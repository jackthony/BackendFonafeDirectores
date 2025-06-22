using Empresa.Application.EMP_Especialidad.Dtos;
using Empresa.Application.EMP_Especialidad.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Empresa.Application.EMP_Especialidad.UseCases
{
    public class ObtenerEspecialidadPorIdUseCase : IUseCase<long, EspecialidadDto?>
    {
        private readonly IReadEspecialidadRepository _repository;

        public ObtenerEspecialidadPorIdUseCase(IReadEspecialidadRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, EspecialidadDto?>> ExecuteAsync(long request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
