/***********
 * Nombre del archivo:  SectorResponse.cs
 * Descripción:         Clase DTO utilizada para exponer la información del sector hacia la capa de presentación.
 *                      Incluye datos como nombre, estado, fechas de registro y modificación, así como el índice de fila.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial del DTO para respuestas del módulo Sector.
 ***********/

namespace Empresa.Presentation.Sector.Responses
{
    public class SectorResponse
    {
        public int nIdSector { get; set; }
        public string sNombreSector { get; set; } = string.Empty;
        public bool bActivo { get; set; }
        public DateTime dtFechaRegistro { get; set; }
        public int nUsuarioRegistro { get; set; }
        public DateTime? dtFechaModificacion { get; set; }
        public int? nUsuarioModificacion { get; set; }
        public int indice { get; set; }
    }
}
