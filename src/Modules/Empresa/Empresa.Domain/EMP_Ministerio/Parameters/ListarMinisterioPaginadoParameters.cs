/***********
 * Nombre del archivo:  ListarMinisterioPaginadoParameters.cs
 * Descripción:         Clase de parámetros utilizada para listar Ministerios con soporte de paginación y filtros por nombre y estado.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para listar registros paginados con filtros.
 ***********/

using Shared.Kernel.Requests;

namespace Empresa.Domain.Ministerio.Parameters
{
    public class ListarMinisterioPaginadoParameters : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
    }
}
