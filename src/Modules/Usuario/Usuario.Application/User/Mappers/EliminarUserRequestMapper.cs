/***********
* Nombre del archivo: EliminarUserRequestMapper.cs
* Descripción:        Implementación del mapeador para transformar una 'EliminarUserRequest' (DTO de aplicación)
*                     a 'EliminarUserParameters' (parámetros de dominio). Este mapper se encarga
*                     de convertir los datos de la solicitud de eliminación de usuario para que sean
*                     utilizables por la capa de dominio.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase mapper.
***********/

using Shared.Kernel.Interfaces;
using Usuario.Application.User.Dtos;
using Usuario.Domain.User.Parameters;

namespace Usuario.Application.User.Mappers
{
    public class EliminarUserRequestMapper : IMapper<EliminarUserRequest, EliminarUserParameters>
    {
        public EliminarUserParameters Map(EliminarUserRequest source)
        {
            throw new NotImplementedException();
        }
    }
}
