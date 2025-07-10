/***********
 * Nombre del archivo:  PermisoRolParameter.cs
 * Descripción:         Clase que representa un parámetro individual de permiso asignado a un rol.
 *                      Contiene la relación entre módulo y acción, y si el permiso está permitido o no.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación de estructura para el manejo de permisos en la asignación de roles.
 ***********/

namespace Usuario.Domain.SEG_Rol.Parameters
{
    public class PermisoRolParameter
    {
        public int ModuloId { get; set; }
        public int AccionId { get; set; }
        public bool Permitir { get; set; }
    }
}
