using Empresa.Domain.EMP_Especialidad.Models;
using Empresa.Domain.EMP_Especialidad.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Especialidad.UseCases
{
    public class ActualizarEspecialidadUseCase : IUseCase<ActualizarEspecialidadData, SpResultBase>
    {
        private readonly IWriteEspecialidadRepository<SpResultBase> _repository;

        public ActualizarEspecialidadUseCase(IWriteEspecialidadRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(ActualizarEspecialidadData request)
        {
            var result = await _repository.UpdateAsync(request);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
