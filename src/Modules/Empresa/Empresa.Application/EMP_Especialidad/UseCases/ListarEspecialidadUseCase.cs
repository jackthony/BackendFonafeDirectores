using Empresa.Application.EMP_Especialidad.Dtos;
using Empresa.Application.EMP_Especialidad.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Empresa.Application.EMP_Especialidad.UseCases
{
    public class ListarEspecialidadUseCase : IUseCase<ListarEspecialidadRequest, List<EspecialidadDto>>
    {
        private readonly IReadEspecialidadRepository _repository;

        public ListarEspecialidadUseCase(IReadEspecialidadRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, List<EspecialidadDto>>> ExecuteAsync(ListarEspecialidadRequest request)
        {
            var result = await _repository.ListAsync(request);
            return result;
        }
    }
}
