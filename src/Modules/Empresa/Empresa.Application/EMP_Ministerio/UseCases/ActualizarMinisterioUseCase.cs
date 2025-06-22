using Empresa.Domain.EMP_Ministerio.Models;
using Empresa.Domain.EMP_Ministerio.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Ministerio.UseCases
{
    public class ActualizarMinisterioUseCase : IUseCase<ActualizarMinisterioData, SpResultBase>
    {
        private readonly IWriteMinisterioRepository<SpResultBase> _repository;

        public ActualizarMinisterioUseCase(IWriteMinisterioRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(ActualizarMinisterioData request)
        {
            var result = await _repository.UpdateAsync(request);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
