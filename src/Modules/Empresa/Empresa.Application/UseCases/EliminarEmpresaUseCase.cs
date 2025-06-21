using Empresa.Domain.EMP_Empresa.Models;
using Empresa.Domain.EMP_Empresa.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.UseCases
{
    public class EliminarEmpresaUseCase : IUseCase<EliminarEmpresaData, SpResultBase>
    {
        private readonly IWriteEmpresaRepository<SpResultBase> _repository;

        public EliminarEmpresaUseCase(IWriteEmpresaRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarEmpresaData request)
        {
            var result = await _repository.DeleteAsync(request);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
