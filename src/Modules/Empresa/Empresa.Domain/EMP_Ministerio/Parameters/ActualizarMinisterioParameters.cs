/***********
 * Nombre del archivo:  ActualizarMinisterioParameters.cs
 * Descripción:         Clase de parámetros utilizada para actualizar los datos de un Ministerio existente,
 *                      incluyendo el identificador, nombre, usuario modificador y fecha de modificación.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para la operación de actualización de ministerios.
 ***********/

namespace Empresa.Domain.Ministerio.Parameters
{
    public class ActualizarMinisterioParameters
    {
        public int MinisterioId { get; set; }
        public string NombreMinisterio { get; set; } = default!;
        public int UsuarioModificacionId { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
