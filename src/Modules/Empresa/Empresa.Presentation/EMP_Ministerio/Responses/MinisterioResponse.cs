/***********
 * Nombre del archivo:  MinisterioResponse.cs
 * Descripción:         Clase de respuesta utilizada en la capa de presentación para representar
 *                      la información del Ministerio. Contiene propiedades básicas como identificador,
 *                      nombre, estado, fechas de auditoría y un índice para paginación.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial del DTO de respuesta para Ministerio.
 ***********/

namespace Empresa.Presentation.Ministerio.Responses
{
    public class MinisterioResponse
    {
        public int nIdMinisterio { get; set; }
        public string sNombreMinisterio { get; set; } = string.Empty;
        public bool bActivo { get; set; }
        public DateTime dtFechaRegistro { get; set; }
        public int nUsuarioRegistro { get; set; }
        public DateTime? dtFechaModificacion { get; set; }
        public int? nUsuarioModificacion { get; set; }
        public int indice { get; set; }
    }
}
