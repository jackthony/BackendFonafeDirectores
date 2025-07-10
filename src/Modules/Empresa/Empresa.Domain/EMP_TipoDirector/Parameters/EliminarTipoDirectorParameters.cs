/***********
 * Nombre del archivo:  EliminarTipoDirectorParameters.cs
 * Descripción:         Clase que define los parámetros necesarios para eliminar un tipo de director.
 *                      Incluye el ID del tipo de director y los datos de trazabilidad de la modificación.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de los parámetros para eliminación de tipo de director.
 ***********/

namespace Empresa.Domain.TipoDirector.Parameters
{
    public class EliminarTipoDirectorParameters
    {
        public int TipoDirectorId { get; set; }
        public int UsuarioModificacionId { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
