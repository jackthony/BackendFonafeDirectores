/***********
 * Nombre del archivo:  PagedRequest.cs
 * Descripción:         Clase que representa una solicitud paginada, incluyendo el número de página
 *                      y el tamaño de página. Es usada comúnmente en consultas con paginación.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 ***********/

namespace Shared.Kernel.Requests
{
    public class PagedRequest
    {
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}
