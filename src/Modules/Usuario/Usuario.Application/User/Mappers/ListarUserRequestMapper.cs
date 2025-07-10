/***********
* Nombre del archivo: ListarUserRequestMapper.cs
* Descripción:        Implementación del mapeador para transformar una 'ListarUserRequest' (DTO de aplicación)
*                     a 'ListarUserParameters' (parámetros de dominio). Este mapper se encarga
*                     de convertir los datos de la solicitud de listar usuarios para que sean
*                     utilizables por la capa de dominio.
* Autor:              Daniel Alva
* Fecha de creación:  10/07/2025
* Última modificación:10/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase mapper.
***********/

using Shared.Kernel.Interfaces;
using Usuario.Application.User.Dtos;
using Usuario.Domain.User.Parameters;

namespace Usuario.Application.User.Mappers
{
    public class ListarUserRequestMapper : IMapper<ListarUserRequest, ListarUserParameters>
    {
        public ListarUserParameters Map(ListarUserRequest source)
        {
            throw new NotImplementedException();
        }
    }
}
