/***********
* Nombre del archivo: ListarRolRequestMapper.cs
* Descripción:        Implementación del mapeador para transformar una 'ListarRolRequest' (DTO de aplicación)
*                     a 'ListarRolParameters' (parámetros de dominio). Este mapper se encarga
*                     de convertir los datos de la solicitud de listar roles para que sean
*                     utilizables por la capa de dominio.
* Autor:              Daniel Alva
* Fecha de creación:  10/07/2025
* Última modificación:10/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase mapper.
***********/

using Shared.Kernel.Interfaces;
using Usuario.Application.Rol.Dtos;
using Usuario.Domain.Rol.Parameters;

namespace Usuario.Application.Rol.Mappers
{
    public class ListarRolRequestMapper : IMapper<ListarRolRequest, ListarRolParameters>
    {
        public ListarRolParameters Map(ListarRolRequest source)
        {
            return new ListarRolParameters
            {
            };
        }
    }
}
