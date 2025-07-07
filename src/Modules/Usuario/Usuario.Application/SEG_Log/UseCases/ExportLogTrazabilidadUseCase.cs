using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Usuario.Application.SEG_Log.Services;
using Usuario.Domain.SEG_Log.Parameters;
using Usuario.Domain.SEG_Log.Repositories;

namespace Usuario.Application.SEG_Log.UseCases
{
    public class ExportLogTrazabilidadUseCase : IUseCase<ObtenerLogTrazabilidadRequest, Stream>
    {
        private readonly IExportLogsRepository _repository;
        private readonly IExportLogsService _exportService;

        public ExportLogTrazabilidadUseCase(
            IExportLogsRepository repository,
            IExportLogsService exportService)
        {
            _repository = repository;
            _exportService = exportService;
        }

        public async Task<OneOf<ErrorBase, Stream>> ExecuteAsync(ObtenerLogTrazabilidadRequest request)
        {
            var logs = await _repository.ObtenerLogTrazabilidadAsync(request);

            /*if (logs == null || logs.Count == 0)
                return ErrorBase.Validation("No se encontraron registros de trazabilidad para las fechas indicadas.");*/

            var stream = _exportService.ExportarLogTrazabilidadExcel(logs);

            return stream;
        }
    }
}
