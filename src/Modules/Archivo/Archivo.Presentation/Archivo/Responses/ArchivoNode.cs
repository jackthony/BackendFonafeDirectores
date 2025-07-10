/*****
 * Nombre del archivo:  ArchivoNode.cs
 * Descripción:         Clase base abstracta que representa un nodo de archivo en la estructura jerárquica de archivos. 
 *                      Define propiedades comunes como `nElementoId`, `sNombre`, `nCarpetaPadreId`, entre otras, que son compartidas por los nodos de carpeta y documento.
 *                      Utiliza atributos de JSON para manejar la serialización polimórfica, permitiendo la distinción entre diferentes tipos de nodos (carpeta o documento) mediante el campo `tipo`.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using System.Text.Json.Serialization;

namespace Archivo.Presentation.Archivo.Responses
{

    [JsonPolymorphic(TypeDiscriminatorPropertyName = "tipo")]
    [JsonDerivedType(typeof(ArchivoCarpeta), 0)]
    [JsonDerivedType(typeof(ArchivoDocumento), 1)]
    public abstract class ArchivoNode
    {
        public int nElementoId { get; set; }
        public string sNombre { get; set; } = string.Empty;
        public int? nCarpetaPadreId { get; set; }
        public int nEmpresaId { get; set; }
        public int nUsuarioRegistroId { get; set; }
        public DateTime dtFechaRegistro { get; set; }
        public abstract bool bEsDocumento { get; }

        [JsonIgnore]
        public abstract int tipo { get; }
    }
}
