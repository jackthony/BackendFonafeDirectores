using Empresa.Domain.EMP_Cargo.Models;
using Empresa.Domain.EMP_Cargo.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Cargo.UseCases
{
    public class CrearCargoUseCase : IUseCase<CrearCargoData, SpResultBase>
    {
        private readonly IWriteCargoRepository<SpResultBase> _repository;

        public CrearCargoUseCase(IWriteCargoRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearCargoData request)
        {
            var result = await _repository.AddAsync(request);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
