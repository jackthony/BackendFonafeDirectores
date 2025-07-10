/***********
* Nombre del archivo: ILogService.cs
* Descripción:        **Define la interfaz para los servicios de registro de logs** en la aplicación.
*                     Proporciona métodos para registrar eventos del sistema y de trazabilidad,
*                     lo que permite desacoplar la lógica de registro de su implementación
*                     y facilita la auditoría y el seguimiento de operaciones importantes.
* Autor:              Daniel Alva
* Fecha de creación:  11/07/2025
* Última modificación:11/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la interfaz ILogService.
***********/

using Usuario.Application.SEG_Log.Dtos;
namespace Usuario.Application.SEG_Log.Services
{
    public interface ILogService
    {
        public Task RegistrarSistemaAsync(LogSistemaRequest dto);
        public Task RegistrarTrazabilidadAsync(LogTrazabilidadRequest dto);
    }
}
