using Empresa.Domain.EMP_TipoDirector.Models;
using Empresa.Domain.EMP_TipoDirector.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_TipoDirector.UseCases
{
    public class EliminarTipoDirectorUseCase : IUseCase<EliminarTipoDirectorData, SpResultBase>
    {
        private readonly IWriteTipoDirectorRepository<SpResultBase> _repository;

        public EliminarTipoDirectorUseCase(IWriteTipoDirectorRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarTipoDirectorData request)
        {
            var result = await _repository.DeleteAsync(request);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
