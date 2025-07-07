using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Usuario.Application.SEG_Log.Services;
using Usuario.Domain.SEG_Log.Parameters;
using Usuario.Domain.SEG_Log.Repositories;

namespace Usuario.Application.SEG_Log.UseCases
{
    public class ExportLogSistemaUseCase : IUseCase<ObtenerLogSistemaPorFechasRequest, Stream>
    {
        private readonly IExportLogsRepository _repository;
        private readonly IExportLogsService _exportService;

        public ExportLogSistemaUseCase(
            IExportLogsRepository repository,
            IExportLogsService exportService)
        {
            _repository = repository;
            _exportService = exportService;
        }

        public async Task<OneOf<ErrorBase, Stream>> ExecuteAsync(ObtenerLogSistemaPorFechasRequest request)
        {
            var logs = await _repository.ObtenerLogSistemaPorFechasAsync(request);

            /*if (logs == null || logs.Count == 0)
                return ErrorBase.Validation("No se encontraron registros de log para las fechas indicadas.");*/

            var stream = _exportService.ExportarLogSistemaExcel(logs);

            return stream;
        }
    }
}
