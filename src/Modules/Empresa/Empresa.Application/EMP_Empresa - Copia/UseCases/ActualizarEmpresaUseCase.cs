using Empresa.Domain.EMP_Empresa.Models;
using Empresa.Domain.EMP_Empresa.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Empresa.UseCases
{
    public class ActualizarEmpresaUseCase : IUseCase<ActualizarEmpresaData, SpResultBase>
    {
        private readonly IWriteEmpresaRepository<SpResultBase> _repository;

        public ActualizarEmpresaUseCase(IWriteEmpresaRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(ActualizarEmpresaData request)
        {
            var result = await _repository.UpdateAsync(request);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
