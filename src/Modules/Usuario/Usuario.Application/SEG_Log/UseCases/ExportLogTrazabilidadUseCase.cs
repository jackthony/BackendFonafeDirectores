/***********
* Nombre del archivo: ExportLogTrazabilidadUseCase.cs
* Descripción:        **Caso de uso** para exportar el log de trazabilidad a un archivo Excel.
*                     Orquesta la obtención de los registros de trazabilidad desde el **repositorio**
*                     y luego utiliza un **servicio de exportación** para generar un flujo (stream)
*                     de datos en formato Excel, listo para ser descargado o procesado.
* Autor:              Daniel Alva
* Fecha de creación:  11/07/2025
* Última modificación:11/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase de caso de uso para exportar el log de trazabilidad a Excel.
***********/

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

            var stream = _exportService.ExportarLogTrazabilidadExcel(logs);

            return stream;
        }
    }
}
