/***********
 * Nombre del archivo:  ListarRolPaginadoParameters.cs
 * Descripción:         Clase que encapsula los parámetros necesarios para listar roles de forma paginada.
 *                      Hereda de PagedRequest e incluye filtros como Nombre y Estado.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación de filtros adicionales para la búsqueda paginada de roles.
 ***********/

using Shared.Kernel.Requests;

namespace Usuario.Domain.Rol.Parameters
{
    public class ListarRolPaginadoParameters : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
    }
}
