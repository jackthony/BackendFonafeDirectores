using Usuario.Application.Dtos;
using Usuario.Application.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Usuario.Application.UseCases
{
    public class ListarUsuarioPaginadasUseCase : IUseCase<ListarUsuarioPaginadoRequest, PagedResult<UsuarioDto>>
    {
        private readonly IReadUsuarioRepository _repository;

        public ListarUsuarioPaginadasUseCase(IReadUsuarioRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, PagedResult<UsuarioDto>>> ExecuteAsync(ListarUsuarioPaginadoRequest request)
        {
            var result = await _repository.ListByPaginationAsync(request);
            return result;
        }
    }
}
