/***********
* Nombre del archivo: ListarUserPaginadoRequest.cs
* Descripción:        DTO (Data Transfer Object) para la solicitud de listar usuarios de forma paginada.
*                     Hereda de 'PagedRequest' para incluir parámetros de paginación y añade
*                     campos específicos para filtrar usuarios por nombre completo y estado.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase DTO para solicitudes de listado de usuarios paginados.
***********/

using Shared.Kernel.Requests;

namespace Usuario.Application.User.Dtos
{
    public class ListarUserPaginadoRequest : PagedRequest
    {
        public string? sNombreCompleto { get; set; }
        public bool? bIsEstado { get; set; }
    }
}
