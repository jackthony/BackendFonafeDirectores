/***********
 * Nombre del archivo:  Pagination.cs
 * Descripción:         Clase que representa información de paginación para una respuesta, incluyendo
 *                      el índice de página, tamaño de página y el total de registros disponibles.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 ***********/

namespace Shared.ClientV1
{
    public class Pagination
    {
        public int PageIndex { get; set; } = 0;
        public int PageSize { get; set; } = 0;
        public int TotalRows { get; set; } = 0;
    }
}
