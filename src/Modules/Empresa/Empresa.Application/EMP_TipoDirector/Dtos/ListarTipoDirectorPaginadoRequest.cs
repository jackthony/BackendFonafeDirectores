/*****
 * Nombre del archivo:  ListarTipoDirectorPaginadoRequest.cs
 * Descripción:         DTO que representa la solicitud paginada para listar tipos de director. 
 *                      Permite aplicar filtros por nombre y estado, y hereda las propiedades de paginación.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/

using Shared.Kernel.Requests;

namespace Empresa.Application.TipoDirector.Dtos
{
    public class ListarTipoDirectorPaginadoRequest : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
    }
}
