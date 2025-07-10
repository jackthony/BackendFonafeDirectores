/***********
* Nombre del archivo: ListarRolPaginadoRequestMapper.cs
* Descripción:        Implementación del mapeador para transformar una 'ListarRolPaginadoRequest' (DTO de aplicación)
*                     a 'ListarRolPaginadoParameters' (parámetros de dominio). Este mapper se encarga
*                     de convertir los datos de la solicitud de listar roles paginados para que sean
*                     utilizables por la capa de dominio, incluyendo los criterios de paginación y filtrado.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase mapper para solicitudes de listado de roles paginados.
***********/

using Shared.Kernel.Interfaces;
using Usuario.Application.Rol.Dtos;
using Usuario.Domain.Rol.Parameters;

namespace Usuario.Application.Rol.Mappers
{
    public class ListarRolPaginadoRequestMapper : IMapper<ListarRolPaginadoRequest, ListarRolPaginadoParameters>
    {
        public ListarRolPaginadoParameters Map(ListarRolPaginadoRequest source)
        {
            return new ListarRolPaginadoParameters
            {
                Page = source.Page,
                PageSize = source.PageSize,
                Estado = source.Estado,
                Nombre = source.Nombre,
            };
        }
    }
}
