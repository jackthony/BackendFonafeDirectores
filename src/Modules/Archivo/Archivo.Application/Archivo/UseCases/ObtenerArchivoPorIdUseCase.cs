using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Archivo.Domain.Archivo.Repositories;
using Archivo.Domain.Archivo.Results;

namespace Archivo.Application.Archivo.UseCases
{
    public class ObtenerArchivoPorIdUseCase : IUseCase<int, ArchivoResult?>
    {
        private readonly IArchivoRepository _repository;

        public ObtenerArchivoPorIdUseCase(IArchivoRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, ArchivoResult?>> ExecuteAsync(int request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
