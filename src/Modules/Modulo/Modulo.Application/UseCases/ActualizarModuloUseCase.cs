using Modulo.Domain.Models;
using Modulo.Domain.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Modulo.Application.UseCases
{
    public class ActualizarModuloUseCase : IUseCase<ActualizarModuloData, SpResultBase>
    {
        private readonly IWriteModuloRepository<SpResultBase> _repository;

        public ActualizarModuloUseCase(IWriteModuloRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(ActualizarModuloData request)
        {
            var result = await _repository.UpdateAsync(request);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
