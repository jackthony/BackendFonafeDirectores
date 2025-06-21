using Rol.Domain.Models;
using Rol.Domain.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Rol.Application.UseCases
{
    public class EliminarRolUseCase : IUseCase<EliminarRolData, SpResultBase>
    {
        private readonly IWriteRolRepository<SpResultBase> _repository;

        public EliminarRolUseCase(IWriteRolRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarRolData request)
        {
            var result = await _repository.DeleteAsync(request);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
