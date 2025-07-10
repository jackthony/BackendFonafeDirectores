/***********
* Nombre del archivo: EliminarRolRequestMapper.cs
* Descripción:        Implementación del mapeador para transformar una 'EliminarRolRequest' (DTO de aplicación)
*                     a 'EliminarRolParameters' (parámetros de dominio). Este mapper se encarga
*                     de convertir los datos de la solicitud de eliminación de rol para que sean
*                     utilizables por la capa de dominio, incluyendo el ID del rol y el ID del usuario
*                     que realiza la modificación.
* Autor:              Daniel Alva
* Fecha de creación:  10/07/2025
* Última modificación:10/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase mapper para solicitudes de eliminación de rol.
***********/

using Shared.Kernel.Interfaces;
using Usuario.Application.Rol.Dtos;
using Usuario.Domain.Rol.Parameters;

namespace Usuario.Application.Rol.Mappers
{
    public class EliminarRolRequestMapper : IMapper<EliminarRolRequest, EliminarRolParameters>
    {
        public EliminarRolParameters Map(EliminarRolRequest source)
        {
            return new EliminarRolParameters()
            {
                RolId = source.nRolId,
                UsuarioModificacionId = source.nUsuarioModificacionId
            };
        }
    }
}
