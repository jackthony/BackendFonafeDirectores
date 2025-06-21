using Usuario.Domain.Models;
using Usuario.Domain.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Usuario.Application.UseCases
{
    public class CrearUsuarioUseCase : IUseCase<CrearUsuarioData, SpResultBase>
    {
        private readonly IWriteUsuarioRepository<SpResultBase> _repository;

        public CrearUsuarioUseCase(IWriteUsuarioRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearUsuarioData request)
        {
            var result = await _repository.AddAsync(request);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
