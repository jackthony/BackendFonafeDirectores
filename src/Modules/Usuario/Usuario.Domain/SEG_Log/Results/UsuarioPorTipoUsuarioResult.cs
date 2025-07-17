/***********
 * Nombre del archivo:  UsuarioPorTipoUsuarioResult.cs
 * Descripción:         Clase que representa el resultado de la consulta de usuarios filtrados por tipo de usuario.
 *                      Contiene datos básicos del usuario como nombre, correo, rol y estado.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial para resultados de consulta de usuarios por tipo.
 ***********/

namespace Usuario.Domain.SEG_Log.Results
{
    public class UsuarioPorTipoUsuarioResult
    {
        public string Username { get; set; } = default!;
        public string CorreoElectronico { get; set; } = default!;
        public string Rol { get; set; } = default!;
        public string ApellidoPaterno { get; set; } = default!;
        public string ApellidoMaterno { get; set; } = default!;
        public string Nombres { get; set; } = default!;
        public string Estado { get; set; } = default!;
        public DateTime? FechaRegistroRol { get; set; }
        public DateTime? FechaModificacionUserRol { get; set; }
    }
}
