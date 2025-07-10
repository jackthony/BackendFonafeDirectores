/***********
* Nombre del archivo: ActualizarRolRequestMapper.cs
* Descripción:        Implementación del mapeador para transformar una 'ActualizarRolRequest' (DTO de aplicación)
*                     a 'ActualizarRolParameters' (parámetros de dominio). Este mapper se encarga
*                     de convertir los datos de la solicitud de actualización de rol para que sean
*                     utilizables por la capa de dominio, incluyendo el ID del rol, su nuevo nombre,
*                     la fecha de modificación y el ID del usuario que realiza la modificación.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase mapper para solicitudes de actualización de rol.
***********/

using Shared.Kernel.Interfaces;
using Usuario.Application.Rol.Dtos;
using Usuario.Domain.Rol.Parameters;

namespace Usuario.Application.Rol.Mappers
{
    public class ActualizarRolRequestMapper : IMapper<ActualizarRolRequest, ActualizarRolParameters>
    {
        public ActualizarRolParameters Map(ActualizarRolRequest source)
        {
            return new ActualizarRolParameters
            {
                RolId = source.nRolId,
                NombreRol = source.sNombreRol,
                FechaModificacion = source.dtFechaModificacion,
                UsuarioModificacionId = source.nIdUsuarioModificacion,
            };
        }
    }
}
