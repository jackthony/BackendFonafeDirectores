/*****
 * Nombre del archivo:  ListResponse.cs
 * Descripción:         Clase genérica que representa una respuesta que contiene una lista de elementos (`LstItem`) y un indicador de éxito (`IsSuccess`). 
 *                      Se utiliza para devolver resultados de tipo lista en las respuestas del sistema.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
namespace Archivo.Presentation.Archivo.Responses
{
    public class ListResponse<T>
    {
        public bool IsSuccess { get; set; }
        public List<T> LstItem { get; set; } = new();
    }
}
