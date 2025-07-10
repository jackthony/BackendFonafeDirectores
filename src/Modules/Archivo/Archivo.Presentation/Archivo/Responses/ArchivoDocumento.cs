/*****
 * Nombre del archivo:  ArchivoDocumento.cs
 * Descripción:         Clase que representa un documento en la estructura de archivos. 
 *                      Hereda de `ArchivoNode` y contiene propiedades específicas de un archivo, como `nPeso`, `sTipoMime` y `sUrlStorage`.
 *                      La propiedad `bEsDocumento` se establece en `true` para indicar que este nodo es un documento, y `tipo` se establece en `1`.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
namespace Archivo.Presentation.Archivo.Responses
{
    public class ArchivoDocumento : ArchivoNode
    {
        public long? nPeso { get; set; }
        public string? sTipoMime { get; set; }
        public string? sUrlStorage { get; set; }

        public override bool bEsDocumento => true;
        public override int tipo => 1;
    }
}
