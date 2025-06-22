using Empresa.Application.EMP_Sector.Dtos;
using Empresa.Application.EMP_Sector.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Sector.UseCases
{
    public class ListarSectorPaginadasUseCase : IUseCase<ListarSectorPaginadoRequest, PagedResult<SectorDto>>
    {
        private readonly IReadSectorRepository _repository;

        public ListarSectorPaginadasUseCase(IReadSectorRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, PagedResult<SectorDto>>> ExecuteAsync(ListarSectorPaginadoRequest request)
        {
            var result = await _repository.ListByPaginationAsync(request);
            return result;
        }
    }
}
