/***********
 * Nombre del archivo:  EliminarSectorParameters.cs
 * Descripción:         Clase que define los parámetros necesarios para eliminar un sector,
 *                      incluyendo el ID del sector y los datos de trazabilidad de la modificación.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de los parámetros para eliminación de sector.
 ***********/

namespace Empresa.Domain.Sector.Parameters
{
    public class EliminarSectorParameters
    {
        public int SectorId { get; set; }
        public int UsuarioModificacionId { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
