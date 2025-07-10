/***********
* Nombre del archivo: ExportLogSistemaUseCase.cs
* Descripción:        **Caso de uso** para exportar el log del sistema, filtrado por fechas, a un archivo Excel.
*                     Orquesta la obtención de los registros del sistema desde el **repositorio**
*                     y luego utiliza un **servicio de exportación** para generar un flujo (stream)
*                     de datos en formato Excel, listo para ser descargado o procesado.
* Autor:              Daniel Alva
* Fecha de creación:  11/07/2025
* Última modificación:11/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase de caso de uso para exportar el log del sistema a Excel.
***********/

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

            var stream = _exportService.ExportarLogSistemaExcel(logs);

            return stream;
        }
    }
}
