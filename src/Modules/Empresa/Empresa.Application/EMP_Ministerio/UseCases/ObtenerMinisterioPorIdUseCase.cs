using Empresa.Application.EMP_Ministerio.Dtos;
using Empresa.Application.EMP_Ministerio.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Empresa.Application.EMP_Ministerio.UseCases
{
    public class ObtenerMinisterioPorIdUseCase : IUseCase<long, MinisterioDto?>
    {
        private readonly IReadMinisterioRepository _repository;

        public ObtenerMinisterioPorIdUseCase(IReadMinisterioRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, MinisterioDto?>> ExecuteAsync(long request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
