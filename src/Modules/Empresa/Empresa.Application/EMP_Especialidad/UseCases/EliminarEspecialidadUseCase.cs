using Empresa.Domain.EMP_Especialidad.Models;
using Empresa.Domain.EMP_Especialidad.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Especialidad.UseCases
{
    public class EliminarEspecialidadUseCase : IUseCase<EliminarEspecialidadData, SpResultBase>
    {
        private readonly IWriteEspecialidadRepository<SpResultBase> _repository;

        public EliminarEspecialidadUseCase(IWriteEspecialidadRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarEspecialidadData request)
        {
            var result = await _repository.DeleteAsync(request);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
