/***********
 * Nombre del archivo:  ListarDirectorPaginadoParameters.cs
 * Descripción:         Parámetros para la paginación y filtrado de la lista de directores.
 *                      Permite filtrar por nombre, estado activo/inactivo y por ID de empresa.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 ***********/
using Shared.Kernel.Requests;

namespace Empresa.Domain.Director.Parameters
{
    public class ListarDirectorPaginadoParameters : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
        public int? nIdEmpresa { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
    }
}
