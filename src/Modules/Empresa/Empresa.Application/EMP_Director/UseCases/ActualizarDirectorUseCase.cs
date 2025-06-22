using Empresa.Domain.EMP_Director.Models;
using Empresa.Domain.EMP_Director.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Director.UseCases
{
    public class ActualizarDirectorUseCase : IUseCase<ActualizarDirectorData, SpResultBase>
    {
        private readonly IWriteDirectorRepository<SpResultBase> _repository;

        public ActualizarDirectorUseCase(IWriteDirectorRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(ActualizarDirectorData request)
        {
            var result = await _repository.UpdateAsync(request);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
