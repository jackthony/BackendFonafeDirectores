/***********
 * Nombre del archivo:  ActualizarRolParameters.cs
 * Descripción:         Clase que contiene los parámetros necesarios para actualizar un rol existente.
 *                      Incluye el Id del rol, el Id del usuario que realiza la modificación,
 *                      la fecha de modificación y el nuevo nombre del rol.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial para la actualización de roles.
 ***********/

namespace Usuario.Domain.Rol.Parameters
{
    public class ActualizarRolParameters
    {
        public int RolId { get; set; }
        public int UsuarioModificacionId {  get; set; }
        public DateTime FechaModificacion { get; set; } = DateTime.Now;
        public string NombreRol { get; set; } = string.Empty;
    }
}
