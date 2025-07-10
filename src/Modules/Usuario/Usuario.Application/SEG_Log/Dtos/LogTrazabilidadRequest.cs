/***********
* Nombre del archivo: LogTrazabilidadRequest.cs
* Descripción:        **DTO** (Data Transfer Object) para la solicitud de registro de un log de trazabilidad.
*                     Contiene información detallada sobre una operación realizada en el sistema,
*                     como el usuario que la ejecutó, el módulo y entidad afectados, el tipo de movimiento,
*                     la sesión, y los datos antes y después del cambio, junto con cualquier detalle adicional.
* Autor:              Daniel Alva
* Fecha de creación:  11/07/2025
* Última modificación:11/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase DTO para el registro de logs de trazabilidad.
***********/

namespace Usuario.Application.SEG_Log.Dtos
{
    public class LogTrazabilidadRequest
    {
        public required int UsuarioId { get; set; }
        public required string Modulo { get; set; }
        public required string Entidad { get; set; }
        public required string Movimiento { get; set; }
        public string? IdSesion { get; set; }
        public string? DatosAntes { get; set; }
        public string? DatosDespues { get; set; }
        public string? Detalles { get; set; }
    }
}
