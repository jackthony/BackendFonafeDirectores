using Empresa.Domain.EMP_Rubro.Models;
using Empresa.Domain.EMP_Rubro.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Rubro.UseCases
{
    public class CrearRubroUseCase : IUseCase<CrearRubroData, SpResultBase>
    {
        private readonly IWriteRubroRepository<SpResultBase> _repository;

        public CrearRubroUseCase(IWriteRubroRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearRubroData request)
        {
            var result = await _repository.AddAsync(request);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
