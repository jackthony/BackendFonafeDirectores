using Empresa.Domain.EMP_Cargo.Models;
using Empresa.Domain.EMP_Cargo.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Cargo.UseCases
{
    public class EliminarCargoUseCase : IUseCase<EliminarCargoData, SpResultBase>
    {
        private readonly IWriteCargoRepository<SpResultBase> _repository;

        public EliminarCargoUseCase(IWriteCargoRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarCargoData request)
        {
            var result = await _repository.DeleteAsync(request);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
