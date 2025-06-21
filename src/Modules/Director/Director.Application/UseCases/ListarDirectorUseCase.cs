using Director.Application.Dtos;
using Director.Application.Repositories;
using Director.Domain.Models;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Director.Application.UseCases
{
    public class ListarDirectorUseCase : IUseCase<ListarDirectorRequest, List<DirectorDto>>
    {
        private readonly IReadDirectorRepository _repository;

        public ListarDirectorUseCase(IReadDirectorRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, List<DirectorDto>>> ExecuteAsync(ListarDirectorRequest request)
        {
            var result = await _repository.ListAsync(request);
            return result;
        }
    }
}
