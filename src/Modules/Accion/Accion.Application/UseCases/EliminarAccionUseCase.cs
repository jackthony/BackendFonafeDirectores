using Accion.Domain.Models;
using Accion.Domain.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Accion.Application.UseCases
{
    public class EliminarAccionUseCase : IUseCase<EliminarAccionData, SpResultBase>
    {
        private readonly IWriteAccionRepository<SpResultBase> _repository;

        public EliminarAccionUseCase(IWriteAccionRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarAccionData request)
        {
            var result = await _repository.DeleteAsync(request);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
