using Empresa.Domain.EMP_Especialidad.Models;
using Empresa.Domain.EMP_Especialidad.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Especialidad.UseCases
{
    public class CrearEspecialidadUseCase : IUseCase<CrearEspecialidadData, SpResultBase>
    {
        private readonly IWriteEspecialidadRepository<SpResultBase> _repository;

        public CrearEspecialidadUseCase(IWriteEspecialidadRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearEspecialidadData request)
        {
            var result = await _repository.AddAsync(request);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
