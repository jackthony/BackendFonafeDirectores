using Modulo.Application.Dtos;
using Modulo.Application.Repositories;
using Modulo.Domain.Models;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Modulo.Application.UseCases
{
    public class ListarModuloUseCase : IUseCase<ListarModuloRequest, List<ModuloDto>>
    {
        private readonly IReadModuloRepository _repository;

        public ListarModuloUseCase(IReadModuloRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, List<ModuloDto>>> ExecuteAsync(ListarModuloRequest request)
        {
            var result = await _repository.ListAsync(request);
            return result;
        }
    }
}
