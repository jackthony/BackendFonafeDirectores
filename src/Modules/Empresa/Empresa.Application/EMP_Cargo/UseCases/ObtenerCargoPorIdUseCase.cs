using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Cargo.Repositories;
using Empresa.Domain.Cargo.Results;

namespace Empresa.Application.Cargo.UseCases
{
    public class ObtenerCargoPorIdUseCase : IUseCase<int, CargoResult?>
    {
        private readonly ICargoRepository _repository;

        public ObtenerCargoPorIdUseCase(ICargoRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, CargoResult?>> ExecuteAsync(int request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
