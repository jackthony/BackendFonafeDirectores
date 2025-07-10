/*****
 * Nombre de clase:     ListarMinisterioPaginadoRequest
 * Descripción:         DTO que hereda de PagedRequest y permite enviar los datos necesarios
 *                      para listar ministerios con paginación y filtros opcionales como nombre y estado.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para representar los filtros de búsqueda paginada de ministerios.
 *****/

using Shared.Kernel.Requests;

namespace Empresa.Application.Ministerio.Dtos
{
    public class ListarMinisterioPaginadoRequest : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
    }
}
