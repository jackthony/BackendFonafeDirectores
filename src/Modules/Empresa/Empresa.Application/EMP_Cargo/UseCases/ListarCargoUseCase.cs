using Empresa.Application.EMP_Cargo.Dtos;
using Empresa.Application.EMP_Cargo.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Empresa.Application.EMP_Cargo.UseCases
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
