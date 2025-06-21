using Rol.Application.Dtos;
using Rol.Application.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Rol.Application.UseCases
{
    public class ObtenerRolPorIdUseCase : IUseCase<long, RolDto?>
    {
        private readonly IReadRolRepository _repository;

        public ObtenerRolPorIdUseCase(IReadRolRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, RolDto?>> ExecuteAsync(long request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
