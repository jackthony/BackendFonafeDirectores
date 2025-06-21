using Empresa.Domain.EMP_Empresa.Models;
using Empresa.Domain.EMP_Empresa.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Empresa.UseCases
{
    public class CrearEmpresaUseCase : IUseCase<CrearEmpresaData, SpResultBase>
    {
        private readonly IWriteEmpresaRepository<SpResultBase> _repository;

        public CrearEmpresaUseCase(IWriteEmpresaRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearEmpresaData request)
        {
            var result = await _repository.AddAsync(request);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
