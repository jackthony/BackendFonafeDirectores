using Sector.Domain.Models;
using Sector.Domain.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Sector.Application.UseCases
{
    public class EliminarSectorUseCase : IUseCase<EliminarSectorData, SpResultBase>
    {
        private readonly IWriteSectorRepository<SpResultBase> _repository;

        public EliminarSectorUseCase(IWriteSectorRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarSectorData request)
        {
            var result = await _repository.DeleteAsync(request);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
