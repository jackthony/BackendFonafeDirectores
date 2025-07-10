/***********
 * Nombre del archivo:  CrearPermisosRolParameters.cs
 * Descripción:         Clase que contiene los parámetros para asignar permisos a un rol.
 *                      Incluye el Id del rol, la lista de permisos, el Id del usuario que realiza
 *                      la modificación y la fecha de la operación.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial para asignación de permisos a roles.
 ***********/

namespace Usuario.Domain.SEG_Rol.Parameters
{
    public class CrearPermisosRolParameters
    {
        public int RolId { get; set; }
        public List<PermisoRolParameter> Permisos { get; set; } = [];
        public int UsuarioModificacionId { get; set; }
        public DateTime FechaOperacion { get; set; }
    }
}
