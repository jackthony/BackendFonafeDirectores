/***********
* Nombre del archivo: LogSistemaRequest.cs
* Descripción:        **DTO** (Data Transfer Object) para la solicitud de registro de un log de sistema.
*                     Contiene información relevante sobre un evento del sistema, como el usuario asociado
*                     (si aplica), el tipo de evento, un mensaje descriptivo, el stack trace (para errores),
*                     el origen del evento, el estado, la dirección IP y el ID de sesión.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase DTO para el registro de logs de sistema.
***********/

namespace Usuario.Application.SEG_Log.Dtos
{
    public class LogSistemaRequest
    {
        public int? UsuarioId { get; set; }
        public string? TipoEvento { get; set; }
        public string? Mensaje { get; set; }
        public string? StackTrace { get; set; }
        public string? Origen { get; set; }
        public int? Estado { get; set; }
        public string? Ip { get; set; }
        public string? IdSession { get; set; }
    }
}
