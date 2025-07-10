/***********
 * Nombre del archivo:  ListarTipoDirectorPaginadoParameters.cs
 * Descripción:         Clase que encapsula los parámetros necesarios para paginar la lista de tipos de director,
 *                      incluyendo filtros por nombre y estado. Hereda de PagedRequest para soportar paginación.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de los parámetros de paginación para tipos de director.
 ***********/

using Shared.Kernel.Requests;

namespace Empresa.Domain.TipoDirector.Parameters
{
    public class ListarTipoDirectorPaginadoParameters : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
    }
}
