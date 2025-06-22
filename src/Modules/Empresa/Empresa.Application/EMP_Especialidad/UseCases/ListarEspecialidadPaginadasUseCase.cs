using Empresa.Application.EMP_Especialidad.Dtos;
using Empresa.Application.EMP_Especialidad.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Especialidad.UseCases
{
    public class ListarEspecialidadPaginadasUseCase : IUseCase<ListarEspecialidadPaginadoRequest, PagedResult<EspecialidadDto>>
    {
        private readonly IReadEspecialidadRepository _repository;

        public ListarEspecialidadPaginadasUseCase(IReadEspecialidadRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, PagedResult<EspecialidadDto>>> ExecuteAsync(ListarEspecialidadPaginadoRequest request)
        {
            var result = await _repository.ListByPaginationAsync(request);
            return result;
        }
    }
}
