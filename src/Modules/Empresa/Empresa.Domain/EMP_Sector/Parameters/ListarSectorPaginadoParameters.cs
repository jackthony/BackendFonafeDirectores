/***********
 * Nombre del archivo:  ListarSectorPaginadoParameters.cs
 * Descripción:         Clase que contiene los parámetros necesarios para realizar una consulta paginada
 *                      de sectores. Permite filtrar por nombre y estado, y hereda de PagedRequest.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de los parámetros para paginación de sectores.
 ***********/

using Shared.Kernel.Requests;

namespace Empresa.Domain.Sector.Parameters
{
    public class ListarSectorPaginadoParameters : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
    }
}
