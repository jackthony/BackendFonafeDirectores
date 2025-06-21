using Usuario.Application.Dtos;
using Usuario.Application.Repositories;
using Usuario.Domain.Models;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Usuario.Application.UseCases
{
    public class ListarUsuarioUseCase : IUseCase<ListarUsuarioRequest, List<UsuarioDto>>
    {
        private readonly IReadUsuarioRepository _repository;

        public ListarUsuarioUseCase(IReadUsuarioRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, List<UsuarioDto>>> ExecuteAsync(ListarUsuarioRequest request)
        {
            var result = await _repository.ListAsync(request);
            return result;
        }
    }
}
