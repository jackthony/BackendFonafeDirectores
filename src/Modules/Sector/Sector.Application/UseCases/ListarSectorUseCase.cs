using Sector.Application.Dtos;
using Sector.Application.Repositories;
using Sector.Domain.Models;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Sector.Application.UseCases
{
    public class ListarSectorUseCase : IUseCase<ListarSectorRequest, List<SectorDto>>
    {
        private readonly IReadSectorRepository _repository;

        public ListarSectorUseCase(IReadSectorRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, List<SectorDto>>> ExecuteAsync(ListarSectorRequest request)
        {
            var result = await _repository.ListAsync(request);
            return result;
        }
    }
}
