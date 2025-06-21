using Sector.Application.Dtos;
using Sector.Application.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Sector.Application.UseCases
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
