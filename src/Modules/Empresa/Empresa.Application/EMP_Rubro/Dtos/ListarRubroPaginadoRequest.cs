/*****
 * Nombre de clase:     ListarRubroPaginadoRequest
 * Descripción:         DTO que hereda de PagedRequest y permite enviar los datos necesarios
 *                      para listar rubros con paginación y filtros opcionales como nombre y estado.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para representar los filtros de búsqueda de rubros paginados.
 *****/

using Shared.Kernel.Requests;

namespace Empresa.Application.Rubro.Dtos
{
    public class ListarRubroPaginadoRequest : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
    }
}
