/***********
 * Nombre del archivo:   UserResponse.cs
 * Descripción:          Clase que representa la estructura de datos de respuesta para un usuario.
 *                       Contiene propiedades con información detallada de un usuario, incluyendo datos personales,
 *                       roles, estados y campos de auditoría.
 * Autor:                Daniel Alva
 * Fecha de creación:    09/07/2025
 * Última modificación:  09/07/2025 por Daniel Alva
 * Cambios recientes:    Creación inicial de la clase para definir la respuesta de usuario.
 **********/

namespace Usuario.Presentation.User.Responses
{
    public class UserResponse
    {
        public int nIdUsuario { get; set; }
        public string sApellidoPaterno { get; set; } = string.Empty;
        public string sApellidoMaterno { get; set; } = string.Empty;
        public string sNombres { get; set; } = string.Empty;
        public int nIdCargo { get; set; }
        public int nTipoPersonal { get; set; }
        public int nIdRol { get; set; }
        public string sCorreoElectronico { get; set; } = string.Empty;
        public int nEstado { get; set; }
        public DateTime dtFechaRegistro { get; set; }
        public int nUsuarioRegistro { get; set; }
        public DateTime? dtFechaModificacion { get; set; }
        public int? nUsuarioModificacion { get; set; }
        public string? sCargoDescripcion { get; set; }
        public string? sPerfilDescripcion { get; set; }
        public string? sEstadoDescripcion { get; set; }
        public string? sApellidosYNombres { get; set; }
        public string? tipoPersonalDescripcion { get; set; }
        public int indice { get; set; }
    }
}
