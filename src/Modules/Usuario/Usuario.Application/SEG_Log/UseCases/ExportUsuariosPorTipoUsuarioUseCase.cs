/***********
* Nombre del archivo: ExportUsuariosPorTipoUsuarioUseCase.cs
* Descripción:        **Caso de uso** para exportar la lista de usuarios filtrada por tipo de usuario a un archivo Excel.
*                     Orquesta la obtención de los datos de usuarios desde el **repositorio**
*                     y luego utiliza un **servicio de exportación** para generar un flujo (stream)
*                     de datos en formato Excel, listo para ser descargado o procesado.
* Autor:              Daniel Alva
* Fecha de creación:  11/07/2025
* Última modificación:11/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase de caso de uso para exportar usuarios por tipo de usuario a Excel.
***********/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Usuario.Application.SEG_Log.Services;
using Usuario.Domain.SEG_Log.Parameters;
using Usuario.Domain.SEG_Log.Repositories;

namespace Usuario.Application.SEG_Log.UseCases
{
    public class ExportUsuariosPorTipoUsuarioUseCase : IUseCase<ObtenerUsuariosPorTipoUsuarioRequest, Stream>
    {
        private readonly IExportLogsRepository _repository;
        private readonly IExportLogsService _exportService;

        public ExportUsuariosPorTipoUsuarioUseCase(
            IExportLogsRepository repository,
            IExportLogsService exportService)
        {
            _repository = repository;
            _exportService = exportService;
        }

        public async Task<OneOf<ErrorBase, Stream>> ExecuteAsync(ObtenerUsuariosPorTipoUsuarioRequest request)
        {
            var usuarios = await _repository.ObtenerUsuariosPorTipoUsuarioAsync(request);

            var stream = _exportService.ExportarUsuariosPorTipoUsuarioExcel(usuarios);

            return stream;
        }
    }
}
