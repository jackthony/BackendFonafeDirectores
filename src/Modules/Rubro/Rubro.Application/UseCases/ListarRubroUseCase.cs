using Rubro.Application.Dtos;
using Rubro.Application.Repositories;
using Rubro.Domain.Models;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Rubro.Application.UseCases
{
    public class ListarRubroUseCase : IUseCase<ListarRubroRequest, List<RubroDto>>
    {
        private readonly IReadRubroRepository _repository;

        public ListarRubroUseCase(IReadRubroRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, List<RubroDto>>> ExecuteAsync(ListarRubroRequest request)
        {
            var result = await _repository.ListAsync(request);
            return result;
        }
    }
}
