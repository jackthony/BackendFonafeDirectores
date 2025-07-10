/***********
* Nombre del archivo: ListarUserPaginadoRequestMapper.cs
* Descripción:        Implementación del mapeador para transformar una 'ListarUserPaginadoRequest' (DTO de aplicación)
*                     a 'ListarUserPaginadoParameters' (parámetros de dominio). Este mapper se encarga
*                     de convertir los datos de la solicitud de listar usuarios paginados para que sean
*                     utilizables por la capa de dominio, incluyendo los criterios de paginación y filtrado.
* Autor:              Daniel Alva
* Fecha de creación:  10/07/2025
* Última modificación:10/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase mapper para solicitudes de listado de usuarios paginados.
***********/

using Shared.Kernel.Interfaces;
using Usuario.Application.User.Dtos;
using Usuario.Domain.User.Parameters;

namespace Usuario.Application.User.Mappers
{
    public class ListarUserPaginadoRequestMapper : IMapper<ListarUserPaginadoRequest, ListarUserPaginadoParameters>
    {
        public ListarUserPaginadoParameters Map(ListarUserPaginadoRequest source)
        {
            return new ListarUserPaginadoParameters
            {
                Page = source.Page,
                PageSize = source.PageSize,
                Nombre = source.sNombreCompleto,
                Estado = source.bIsEstado
            };
        }
    }
}
