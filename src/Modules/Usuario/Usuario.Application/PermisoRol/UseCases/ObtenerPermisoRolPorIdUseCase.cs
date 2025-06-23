using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Usuario.Domain.PermisoRol.Repositories;
using Usuario.Domain.PermisoRol.Results;

namespace Usuario.Application.PermisoRol.UseCases
{
    public class ObtenerPermisoRolPorIdUseCase : IUseCase<int, PermisoRolResult?>
    {
        private readonly IPermisoRolRepository _repository;

        public ObtenerPermisoRolPorIdUseCase(IPermisoRolRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, PermisoRolResult?>> ExecuteAsync(int request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
