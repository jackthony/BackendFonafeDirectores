using Rol.Domain.Models;
using Rol.Domain.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Rol.Application.UseCases
{
    public class CrearRolUseCase : IUseCase<CrearRolData, SpResultBase>
    {
        private readonly IWriteRolRepository<SpResultBase> _repository;

        public CrearRolUseCase(IWriteRolRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearRolData request)
        {
            var result = await _repository.AddAsync(request);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
