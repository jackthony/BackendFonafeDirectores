/*****
 * Nombre del archivo:  ArchivoCarpeta.cs
 * Descripción:         Clase que representa una carpeta en la estructura de archivos. 
 *                      Hereda de `ArchivoNode` y contiene una lista de elementos hijos (`ltHijos`), los cuales son nodos de archivo. 
 *                      La propiedad `bEsDocumento` se establece en `false` para indicar que este nodo es una carpeta, y `tipo` se establece en `0`.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
namespace Archivo.Presentation.Archivo.Responses
{
    public class ArchivoCarpeta : ArchivoNode
    {
        public List<ArchivoNode> ltHijos { get; set; } = [];
        public override bool bEsDocumento => false;
        public override int tipo => 0;
    }
}
