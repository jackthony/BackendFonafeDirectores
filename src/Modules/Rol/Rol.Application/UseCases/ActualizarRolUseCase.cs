using Rol.Domain.Models;
using Rol.Domain.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Rol.Application.UseCases
{
    public class ActualizarRolUseCase : IUseCase<ActualizarRolData, SpResultBase>
    {
        private readonly IWriteRolRepository<SpResultBase> _repository;

        public ActualizarRolUseCase(IWriteRolRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(ActualizarRolData request)
        {
            var result = await _repository.UpdateAsync(request);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
