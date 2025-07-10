/***********
* Nombre del archivo: ExportAuditoriaUsuariosUseCase.cs
* Descripción:        **Caso de uso** para exportar la auditoría de usuarios a un archivo Excel.
*                     Orquesta la obtención de los registros de auditoría de usuarios desde el **repositorio**
*                     y luego utiliza un **servicio de exportación** para generar un flujo (stream)
*                     de datos en formato Excel, listo para ser descargado o procesado.
* Autor:              Daniel Alva
* Fecha de creación:  11/07/2025
* Última modificación:11/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase de caso de uso para exportar la auditoría de usuarios a Excel.
***********/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Usuario.Application.SEG_Log.Services;
using Usuario.Domain.SEG_Log.Parameters;
using Usuario.Domain.SEG_Log.Repositories;

namespace Usuario.Application.SEG_Log.UseCases
{
    public class ExportAuditoriaUsuariosUseCase : IUseCase<ObtenerAuditoriaUsuariosRequest, Stream>
    {
        private readonly IExportLogsRepository _repository;
        private readonly IExportLogsService _exportService;

        public ExportAuditoriaUsuariosUseCase(
            IExportLogsRepository repository,
            IExportLogsService exportService)
        {
            _repository = repository;
            _exportService = exportService;
        }

        public async Task<OneOf<ErrorBase, Stream>> ExecuteAsync(ObtenerAuditoriaUsuariosRequest request)
        {
            var usuarios = await _repository.ObtenerAuditoriaUsuariosAsync(request);

            var stream = _exportService.ExportarAuditoriaUsuariosExcel(usuarios);

            return stream;
        }
    }
}
