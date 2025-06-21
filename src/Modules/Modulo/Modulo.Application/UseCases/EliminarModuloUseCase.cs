using Modulo.Domain.Models;
using Modulo.Domain.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Modulo.Application.UseCases
{
    public class EliminarModuloUseCase : IUseCase<EliminarModuloData, SpResultBase>
    {
        private readonly IWriteModuloRepository<SpResultBase> _repository;

        public EliminarModuloUseCase(IWriteModuloRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarModuloData request)
        {
            var result = await _repository.DeleteAsync(request);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
