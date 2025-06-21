using Especialidad.Application.Dtos;
using Especialidad.Application.Repositories;
using Especialidad.Domain.Models;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Especialidad.Application.UseCases
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
