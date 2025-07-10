/***********
* Nombre del archivo: ActualizarPermisoRolRequestMapper.cs
* Descripción:        **Implementación del mapeador** para transformar una **`ActualizarPermisoRolRequest`** (DTO de aplicación)
*                     a **`ActualizarPermisoRolParameters`** (parámetros de dominio). Este mapeador se encarga
*                     de convertir los datos de la solicitud de actualización de un permiso de rol para que sean
*                     utilizables por la capa de dominio, incluyendo los IDs de rol, módulo, acción,
*                     el ID del usuario que modifica y la fecha de modificación.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase mapeadora para solicitudes de actualización de permisos de rol.
***********/

using Shared.Kernel.Interfaces;
using Usuario.Application.PermisoRol.Dtos;
using Usuario.Domain.PermisoRol.Parameters;

namespace Usuario.Application.PermisoRol.Mappers
{
    public class ActualizarPermisoRolRequestMapper : IMapper<ActualizarPermisoRolRequest, ActualizarPermisoRolParameters>
    {
        public ActualizarPermisoRolParameters Map(ActualizarPermisoRolRequest source)
        {
            return new ActualizarPermisoRolParameters
            {
                nRolId = source.nRolId,
                nModuloId = source.nModuloId,
                nAccionId = source.nAccionId,
                nUsuarioModificacionId = source.nUsuarioModificacionId,
                dtFechaModificacion = source.dtFechaModificacion
            };
        }
    }
}
