/***********
 * Nombre del archivo:  SectorResult.cs
 * Descripción:         DTO que representa los datos de un sector, incluyendo su identificador, nombre,
 *                      estado de actividad, fechas de registro y modificación, y los usuarios responsables.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial del DTO SectorResult.
 ***********/

namespace Empresa.Domain.Sector.Results
{
    public class SectorResult
    {
        public int SectorId { get; set; }
        public string NombreSector { get; set; } = default!;
        public bool IsActivo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? UsuarioModificacionId { get; set; }
    }
}
