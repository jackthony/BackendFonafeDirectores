using Rol.Application.Dtos;
using Rol.Application.Repositories;
using Rol.Domain.Models;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Rol.Application.UseCases
{
    public class ListarRolUseCase : IUseCase<ListarRolRequest, List<RolDto>>
    {
        private readonly IReadRolRepository _repository;

        public ListarRolUseCase(IReadRolRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, List<RolDto>>> ExecuteAsync(ListarRolRequest request)
        {
            var result = await _repository.ListAsync(request);
            return result;
        }
    }
}
