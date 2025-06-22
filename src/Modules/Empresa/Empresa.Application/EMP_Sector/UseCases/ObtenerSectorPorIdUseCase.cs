using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Sector.Repositories;
using Empresa.Domain.Sector.Results;

namespace Empresa.Application.Sector.UseCases
{
    public class ObtenerSectorPorIdUseCase : IUseCase<int, SectorResult?>
    {
        private readonly ISectorRepository _repository;

        public ObtenerSectorPorIdUseCase(ISectorRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SectorResult?>> ExecuteAsync(int request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
