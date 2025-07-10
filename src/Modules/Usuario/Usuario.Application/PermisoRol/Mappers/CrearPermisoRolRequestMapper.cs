/***********
* Nombre del archivo: CrearPermisoRolRequestMapper.cs
* Descripción:        **Implementación del mapeador** para transformar una **`CrearPermisoRolRequest`** (DTO de aplicación)
*                     a **`CrearPermisoRolParameters`** (parámetros de dominio). Este mapeador se encarga
*                     de convertir los datos de la solicitud de creación de un permiso de rol para que sean
*                     utilizables por la capa de dominio, incluyendo los IDs de rol, módulo, acción,
*                     el ID del usuario que registra y la fecha de registro, la cual es proporcionada
*                     por un proveedor de tiempo para asegurar consistencia.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase mapeadora para solicitudes de creación de permisos de rol.
***********/

using Shared.Kernel.Interfaces;
using Shared.Time;
using Usuario.Application.PermisoRol.Dtos;
using Usuario.Domain.PermisoRol.Parameters;

namespace Usuario.Application.PermisoRol.Mappers
{
    public class CrearPermisoRolRequestMapper : IMapper<CrearPermisoRolRequest, CrearPermisoRolParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public CrearPermisoRolRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public CrearPermisoRolParameters Map(CrearPermisoRolRequest source)
        {
            return new CrearPermisoRolParameters
            {
                nRolId = source.nRolId,
                nModuloId = source.nModuloId,
                nAccionId = source.nAccionId,
                nUsuarioRegistroId = source.nUsuarioRegistroId,
                dtFechaRegistro = _timeProvider.NowPeru
            };
        }
    }
}
