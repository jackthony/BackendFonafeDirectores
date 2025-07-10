/***********
 * Nombre del archivo:  EliminarDirectorParameters.cs
 * Descripción:         Clase que contiene los parámetros necesarios para eliminar un director,
 *                      incluyendo el identificador del director, usuario que realiza la modificación
 *                      y la fecha de modificación.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación de la clase para parámetros de eliminación de director.
 ***********/

namespace Empresa.Domain.Director.Parameters
{
    public class EliminarDirectorParameters
    {
        public int nDirectorId { get; set; }
        public int nUsuarioModificacionId { get; set; }
        public DateTime dtFechaModificacion { get; set; }
    }
}
