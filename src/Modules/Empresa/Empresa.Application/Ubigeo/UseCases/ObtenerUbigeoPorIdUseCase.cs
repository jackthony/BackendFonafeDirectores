using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Ubigeo.Repositories;
using Empresa.Domain.Ubigeo.Results;

namespace Empresa.Application.Ubigeo.UseCases
{
    public class ObtenerUbigeoPorIdUseCase : IUseCase<int, UbigeoResult?>
    {
        private readonly IUbigeoRepository _repository;

        public ObtenerUbigeoPorIdUseCase(IUbigeoRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, UbigeoResult?>> ExecuteAsync(int request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
