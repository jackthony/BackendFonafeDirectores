using Empresa.Domain.EMP_Ministerio.Models;
using Empresa.Domain.EMP_Ministerio.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Ministerio.UseCases
{
    public class CrearMinisterioUseCase : IUseCase<CrearMinisterioData, SpResultBase>
    {
        private readonly IWriteMinisterioRepository<SpResultBase> _repository;

        public CrearMinisterioUseCase(IWriteMinisterioRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearMinisterioData request)
        {
            var result = await _repository.AddAsync(request);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
