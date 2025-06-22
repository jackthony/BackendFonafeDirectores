using Empresa.Application.EMP_Sector.Dtos;
using Empresa.Application.EMP_Sector.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Empresa.Application.EMP_Sector.UseCases
{
    public class ObtenerSectorPorIdUseCase : IUseCase<long, SectorDto?>
    {
        private readonly IReadSectorRepository _repository;

        public ObtenerSectorPorIdUseCase(IReadSectorRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SectorDto?>> ExecuteAsync(long request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
