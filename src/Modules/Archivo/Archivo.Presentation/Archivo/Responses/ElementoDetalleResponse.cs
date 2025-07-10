/*****
 * Nombre del archivo:  ElementoDetalleResponse.cs
 * Descripción:         Clase que representa los detalles de un elemento en la estructura de archivos. 
 *                      Incluye propiedades como `nPeso`, `sTipoMime`, `sUrlStorage`, `nElementoId`, y `sNombre`, entre otras, 
 *                      que definen un archivo o carpeta y sus atributos asociados.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
namespace Archivo.Presentation.Archivo.Responses
{
    public class ElementoDetalleResponse
    {
        public int tipo { get; set; }
        public long nPeso { get; set; }
        public string sTipoMime { get; set; } = string.Empty;
        public string sUrlStorage { get; set; } = string.Empty;
        public bool bEsDocumento { get; set; }
        public int nElementoId { get; set; }
        public string sNombre { get; set; } = string.Empty;
        public int? nCarpetaPadreId { get; set; }
        public int nEmpresaId { get; set; }
        public int nUsuarioRegistroId { get; set; }
        public DateTime stFechaRegistro { get; set; }
    }
}
