/***********
 * Nombre del archivo:  ActualizarSectorParameters.cs
 * Descripción:         Clase que define los parámetros necesarios para actualizar un sector,
 *                      incluyendo el ID del sector, el nuevo nombre y los datos de trazabilidad.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de los parámetros para actualización de sector.
 ***********/

namespace Empresa.Domain.Sector.Parameters
{
    public class ActualizarSectorParameters
    {
        public int SectorId { get; set; }
        public string NombreSector { get; set; } = default!;
        public int UsuarioModificacionId { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
