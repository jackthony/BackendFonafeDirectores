using Accion.Domain.Models;
using Accion.Domain.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Accion.Application.UseCases
{
    public class CrearAccionUseCase : IUseCase<CrearAccionData, SpResultBase>
    {
        private readonly IWriteAccionRepository<SpResultBase> _repository;

        public CrearAccionUseCase(IWriteAccionRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearAccionData request)
        {
            var result = await _repository.AddAsync(request);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
