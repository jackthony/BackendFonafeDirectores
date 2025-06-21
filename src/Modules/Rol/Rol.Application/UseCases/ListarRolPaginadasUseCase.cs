using Rol.Application.Dtos;
using Rol.Application.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Rol.Application.UseCases
{
    public class ListarRolPaginadasUseCase : IUseCase<ListarRolPaginadoRequest, PagedResult<RolDto>>
    {
        private readonly IReadRolRepository _repository;

        public ListarRolPaginadasUseCase(IReadRolRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, PagedResult<RolDto>>> ExecuteAsync(ListarRolPaginadoRequest request)
        {
            var result = await _repository.ListByPaginationAsync(request);
            return result;
        }
    }
}
