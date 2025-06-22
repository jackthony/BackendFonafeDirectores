using Empresa.Domain.EMP_TipoDirector.Models;
using Empresa.Domain.EMP_TipoDirector.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_TipoDirector.UseCases
{
    public class ActualizarTipoDirectorUseCase : IUseCase<ActualizarTipoDirectorData, SpResultBase>
    {
        private readonly IWriteTipoDirectorRepository<SpResultBase> _repository;

        public ActualizarTipoDirectorUseCase(IWriteTipoDirectorRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(ActualizarTipoDirectorData request)
        {
            var result = await _repository.UpdateAsync(request);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
