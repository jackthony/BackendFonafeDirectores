using Archivo.Application.Archivo.Dtos;
using Archivo.Application.Archivo.Services;
using Archivo.Domain.Archivo.Repositories;
using Archivo.Domain.Archivo.Results;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Archivo.Application.Archivo.UseCases
{
    public class ImportFileUseCase : IUseCase<ImportFileRequest, ImportFileResult>
    {
        private readonly IExportImportService _service;
        private readonly IExportImportRepository _repository;

        public ImportFileUseCase(IExportImportService service, IExportImportRepository repository)
        {
            _service = service;
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, ImportFileResult>> ExecuteAsync(ImportFileRequest request)
        {
            var result = _service.ImportAsync(request);

            if (result.Empresas.Count == 0 && result.Directores.Count == 0)
                return ErrorBase.Validation("El archivo no contiene datos válidos.");

            await _repository.InsertEmpresasAsync(result.Empresas);

            await _repository.InsertDirectoresAsync(result.Directores);

            return result;
        }
    }
}
