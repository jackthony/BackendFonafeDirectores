using Empresa.Application.EMP_Sector.Dtos;
using Empresa.Application.EMP_Sector.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Empresa.Application.EMP_Sector.UseCases
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
