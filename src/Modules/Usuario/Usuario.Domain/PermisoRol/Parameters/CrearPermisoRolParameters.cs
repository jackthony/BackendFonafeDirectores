/***********
 * Nombre del archivo:  CrearPermisoRolParameters.cs
 * Descripción:         Clase que contiene los parámetros necesarios
 *                      para crear un nuevo permiso asignado a un rol,
 *                      incluyendo identificadores y datos de registro.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial de la clase de parámetros.
 ***********/

namespace Usuario.Domain.PermisoRol.Parameters
{
    public class CrearPermisoRolParameters
    {
        public int nRolId { get; set; }
        public int nModuloId { get; set; }
        public int nAccionId { get; set; }
        public int nUsuarioRegistroId { get; set; }
        public DateTime dtFechaRegistro { get; set; }
    }
}
