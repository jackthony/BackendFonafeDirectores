using TipoDirector.Application.Dtos;
using TipoDirector.Application.Repositories;
using TipoDirector.Domain.Models;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace TipoDirector.Application.UseCases
{
    public class ListarTipoDirectorUseCase : IUseCase<ListarTipoDirectorRequest, List<TipoDirectorDto>>
    {
        private readonly IReadTipoDirectorRepository _repository;

        public ListarTipoDirectorUseCase(IReadTipoDirectorRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, List<TipoDirectorDto>>> ExecuteAsync(ListarTipoDirectorRequest request)
        {
            var result = await _repository.ListAsync(request);
            return result;
        }
    }
}
