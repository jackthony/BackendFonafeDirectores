/***********
 * Nombre del archivo:  TipoDirectorResponse.cs
 * Descripción:         Clase de respuesta que representa la estructura de un TipoDirector
 *                      para su consumo en la capa de presentación.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial del DTO de respuesta para TipoDirector.
 ***********/

namespace Empresa.Presentation.TipoDirector.Responses
{
    public class TipoDirectorResponse
    {
        public int nIdTipoDirector { get; set; }
        public string sNombreTipoDirector { get; set; } = string.Empty;
        public bool bActivo { get; set; }
        public DateTime dtFechaRegistro { get; set; }
        public int nUsuarioRegistro { get; set; }
        public DateTime? dtFechaModificacion { get; set; }
        public int? nUsuarioModificacion { get; set; }
        public int indice { get; set; }
    }
}
