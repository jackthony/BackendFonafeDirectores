using Empresa.Domain.EMP_Director.Models;
using Empresa.Domain.EMP_Director.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Director.UseCases
{
    public class CrearDirectorUseCase : IUseCase<CrearDirectorData, SpResultBase>
    {
        private readonly IWriteDirectorRepository<SpResultBase> _repository;

        public CrearDirectorUseCase(IWriteDirectorRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearDirectorData request)
        {
            var result = await _repository.AddAsync(request);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
