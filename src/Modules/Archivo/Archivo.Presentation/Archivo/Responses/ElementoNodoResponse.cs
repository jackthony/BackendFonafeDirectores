/*****
 * Nombre del archivo:  ElementoNodoResponse.cs
 * Descripción:         Clase genérica que representa un nodo de un elemento en una estructura jerárquica. 
 *                      Contiene propiedades como `id`, `name`, `codeParent`, y un tipo genérico `T` que representa el elemento asociado al nodo. 
 *                      También incluye propiedades para gestionar los hijos del nodo (`Children`) y si el nodo tiene hijos (`hasChildren`).
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
namespace Archivo.Presentation.Archivo.Responses
{
    public class ElementoNodoResponse<T>
    {
        public int id { get; set; }
        public string name { get; set; } = string.Empty;
        public int? codeParent { get; set; }
        public int status { get; set; }
        public T? element { get; set; }
        public bool hasChildren { get; set; }
        public List<ElementoNodoResponse<T>> Children { get; set; } = [];
    }
}
