using Rubro.Domain.Models;
using Rubro.Domain.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Rubro.Application.UseCases
{
    public class EliminarRubroUseCase : IUseCase<EliminarRubroData, SpResultBase>
    {
        private readonly IWriteRubroRepository<SpResultBase> _repository;

        public EliminarRubroUseCase(IWriteRubroRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarRubroData request)
        {
            var result = await _repository.DeleteAsync(request);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
