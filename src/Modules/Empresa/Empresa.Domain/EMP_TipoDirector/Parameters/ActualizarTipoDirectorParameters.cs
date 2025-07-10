/***********
 * Nombre del archivo:  ActualizarTipoDirectorParameters.cs
 * Descripción:         Clase que encapsula los parámetros necesarios para actualizar un tipo de director.
 *                      Incluye el ID, el nuevo nombre y los datos de trazabilidad de la modificación.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de los parámetros para actualización de tipo de director.
 ***********/

namespace Empresa.Domain.TipoDirector.Parameters
{
    public class ActualizarTipoDirectorParameters
    {
        public int TipoDirectorId { get; set; }
        public string NombreTipoDirector { get; set; } = default!;
        public int UsuarioModificacionId { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
