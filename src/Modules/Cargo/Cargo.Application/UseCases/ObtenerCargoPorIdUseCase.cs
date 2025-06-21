using Cargo.Application.Dtos;
using Cargo.Application.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Cargo.Application.UseCases
{
    public class ObtenerCargoPorIdUseCase : IUseCase<long, CargoDto?>
    {
        private readonly IReadCargoRepository _repository;

        public ObtenerCargoPorIdUseCase(IReadCargoRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, CargoDto?>> ExecuteAsync(long request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
