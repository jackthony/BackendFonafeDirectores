using Cargo.Application.Dtos;
using Cargo.Application.Repositories;
using Cargo.Domain.Models;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Cargo.Application.UseCases
{
    public class ListarCargoUseCase : IUseCase<ListarCargoRequest, List<CargoDto>>
    {
        private readonly IReadCargoRepository _repository;

        public ListarCargoUseCase(IReadCargoRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, List<CargoDto>>> ExecuteAsync(ListarCargoRequest request)
        {
            var result = await _repository.ListAsync(request);
            return result;
        }
    }
}
