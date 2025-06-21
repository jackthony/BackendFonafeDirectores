using Accion.Domain.Models;
using Accion.Domain.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Accion.Application.UseCases
{
    public class ActualizarAccionUseCase : IUseCase<ActualizarAccionData, SpResultBase>
    {
        private readonly IWriteAccionRepository<SpResultBase> _repository;

        public ActualizarAccionUseCase(IWriteAccionRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(ActualizarAccionData request)
        {
            var result = await _repository.UpdateAsync(request);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
