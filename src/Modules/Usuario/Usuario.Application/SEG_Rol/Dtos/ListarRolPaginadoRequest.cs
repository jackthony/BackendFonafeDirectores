/***********
* Nombre del archivo: ListarRolPaginadoRequest.cs
* Descripción:        DTO (Data Transfer Object) para la solicitud de listar roles de forma paginada.
*                     Hereda de 'PagedRequest' para incluir parámetros de paginación y añade
*                     campos específicos para filtrar roles por nombre y estado.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase DTO para solicitudes de listado de roles paginados.
***********/

using Shared.Kernel.Requests;

namespace Usuario.Application.Rol.Dtos
{
    public class ListarRolPaginadoRequest : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
    }
}
