/***********
* Nombre del archivo: EliminarPermisoRolRequestMapper.cs
* Descripción:        **Implementación del mapeador** para transformar una **`EliminarPermisoRolRequest`** (DTO de aplicación)
*                     a **`EliminarPermisoRolParameters`** (parámetros de dominio). Este mapeador se encarga
*                     de convertir los datos de la solicitud de eliminación de un permiso de rol para que sean
*                     utilizables por la capa de dominio, incluyendo los IDs de rol, módulo, acción,
*                     el ID del usuario que modifica y la fecha de modificación.
* Autor:              Daniel Alva
* Fecha de creación:  11/07/2025
* Última modificación:11/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase mapeadora para solicitudes de eliminación de permisos de rol.
***********/

using Shared.Kernel.Interfaces;
using Usuario.Application.PermisoRol.Dtos;
using Usuario.Domain.PermisoRol.Parameters;

namespace Usuario.Application.PermisoRol.Mappers
{
    public class EliminarPermisoRolRequestMapper : IMapper<EliminarPermisoRolRequest, EliminarPermisoRolParameters>
    {
        public EliminarPermisoRolParameters Map(EliminarPermisoRolRequest source)
        {
            return new EliminarPermisoRolParameters
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
