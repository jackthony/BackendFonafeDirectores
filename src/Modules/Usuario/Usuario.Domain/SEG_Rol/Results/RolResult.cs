/***********
 * Nombre del archivo:  RolResult.cs
 * Descripción:         Modelo que representa el resultado de una consulta a la entidad Rol.
 *                      Contiene información relevante del rol, como su estado, fechas y usuarios relacionados.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial del modelo de resultado para roles.
 ***********/

namespace Usuario.Domain.Rol.Results
{
    public class RolResult
    {
        public int RolId { get; set; }
        public string NombreRol { get; set; } =  string.Empty;
        public bool Activo { get; set; }
        public DateTime FechaRegistro  { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? UsuarioModificacionId { get; set; }
    }
}
