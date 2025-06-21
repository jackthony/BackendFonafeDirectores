using Sector.Domain.Models;
using Sector.Domain.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Sector.Application.UseCases
{
    public class ActualizarSectorUseCase : IUseCase<ActualizarSectorData, SpResultBase>
    {
        private readonly IWriteSectorRepository<SpResultBase> _repository;

        public ActualizarSectorUseCase(IWriteSectorRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(ActualizarSectorData request)
        {
            var result = await _repository.UpdateAsync(request);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
