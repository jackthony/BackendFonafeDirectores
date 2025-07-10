/***********
 * Nombre del archivo:  PagedResult.cs
 * Descripción:         Clase genérica que representa una respuesta paginada. Contiene la lista de elementos,
 *                      el total de ítems, la página actual y el tamaño de página.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 ***********/

namespace Shared.Kernel.Responses
{
    public class PagedResult<T>
    {
        public List<T> Items { get; set; } = [];
        public int TotalItems { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
