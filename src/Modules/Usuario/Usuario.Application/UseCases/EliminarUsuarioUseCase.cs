using Usuario.Domain.Models;
using Usuario.Domain.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Usuario.Application.UseCases
{
    public class EliminarUsuarioUseCase : IUseCase<EliminarUsuarioData, SpResultBase>
    {
        private readonly IWriteUsuarioRepository<SpResultBase> _repository;

        public EliminarUsuarioUseCase(IWriteUsuarioRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarUsuarioData request)
        {
            var result = await _repository.DeleteAsync(request);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
