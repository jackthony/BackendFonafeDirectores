/***********
 * Nombre del archivo:  ListarUserPaginadoParameters.cs
 * Descripción:         Clase de parámetros para el listado paginado de usuarios.
 *                      Permite filtrar por nombre y estado.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Definición inicial de parámetros para el paginado y filtrado de usuarios.
 ***********/

using Shared.Kernel.Requests;

namespace Usuario.Domain.User.Parameters
{
    public class ListarUserPaginadoParameters : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
    }
}
