/***********
 * Nombre del archivo:   RolResponse.cs
 * Descripción:          Clase que define la estructura de datos de respuesta para un rol dentro del sistema.
 *                       Contiene las propiedades relevantes de un rol, incluyendo su identificación, nombre, estado,
 *                       y datos de auditoría para ser expuestos en la capa de presentación.
 * Autor:                Daniel Alva
 * Fecha de creación:    09/07/2025
 * Última modificación:  09/07/2025 por Daniel Alva
 * Cambios recientes:    Creación inicial de la clase para definir la respuesta de rol.
 **********/

namespace Usuario.Presentation.Rol.Responses
{
    public class RolResponse
    {
        public int nRolId { get; set; }
        public string sNombreRol { get; set; } = string.Empty;
        public bool bActivo { get; set; }
        public DateTime dtFechaRegistro { get; set; }
        public int nUsuarioRegistroId { get; set; }
        public DateTime? dtFechaModificacion { get; set; }
        public int? nUsuarioModificacionId { get; set; }
        public int indice { get; set; }
    }
}