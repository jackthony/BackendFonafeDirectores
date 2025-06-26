using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Usuario.Domain.Rol.Repositories;
using Usuario.Domain.Rol.Results;

namespace Usuario.Application.Rol.UseCases
{
    public class ObtenerRolPorIdUseCase : IUseCase<int, RolResult?>
    {
        private readonly IRolRepository _repository;

        public ObtenerRolPorIdUseCase(IRolRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, RolResult?>> ExecuteAsync(int request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
