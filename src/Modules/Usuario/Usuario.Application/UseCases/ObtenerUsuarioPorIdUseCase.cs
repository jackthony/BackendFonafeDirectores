using Usuario.Application.Dtos;
using Usuario.Application.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Usuario.Application.UseCases
{
    public class ObtenerUsuarioPorIdUseCase : IUseCase<long, UsuarioDto?>
    {
        private readonly IReadUsuarioRepository _repository;

        public ObtenerUsuarioPorIdUseCase(IReadUsuarioRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, UsuarioDto?>> ExecuteAsync(long request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
