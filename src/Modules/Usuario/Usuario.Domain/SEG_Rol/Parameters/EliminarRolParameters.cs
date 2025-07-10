/***********
 * Nombre del archivo:  EliminarRolParameters.cs
 * Descripción:         Clase que representa los parámetros necesarios para eliminar un rol.
 *                      Contiene el Id del rol a eliminar, el Id del usuario que realiza la modificación
 *                      y la fecha en que se realiza dicha modificación.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial para manejo de eliminación de roles.
 ***********/

namespace Usuario.Domain.Rol.Parameters
{
    public class EliminarRolParameters
    {
        public int RolId { get; set; }
        public int UsuarioModificacionId { get; set; }
        public DateTime FechaModificacion { get; set; } = DateTime.Now;
    }
}
