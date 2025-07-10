/***********
 * Nombre del archivo:  ActualizarUserParameters.cs
 * Descripción:         Clase de parámetros utilizada para actualizar los datos de un usuario.
 *                      Incluye identificadores clave, rol, estado, cargo y tipo de personal.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial del modelo de entrada para la actualización de usuarios.
 ***********/

namespace Usuario.Domain.User.Parameters
{
    public class ActualizarUserParameters
    {
        public int UsuarioId { get; set; }
        public int UsuarioModificacionId { get; set; }
        public int RolId { get; set; }
        public int Estado { get; set; }
        public int CargoId { get; set; }
        public int nTipoPersonal { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
