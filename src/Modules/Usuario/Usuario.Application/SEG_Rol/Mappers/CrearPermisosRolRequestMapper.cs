/***********
* Nombre del archivo: CrearPermisosRolRequestMapper.cs
* Descripción:        Implementación del mapeador para transformar una 'CrearPermisosRolRequest' (DTO de aplicación)
*                     a 'CrearPermisosRolParameters' (parámetros de dominio). Este mapper se encarga
*                     de convertir los datos de la solicitud de creación/actualización de permisos de rol,
*                     extrayendo los módulos y acciones, y asignando la fecha de operación para que sean
*                     utilizables por la capa de dominio.
* Autor:              Daniel Alva
* Fecha de creación:  10/07/2025
* Última modificación:10/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase mapper para solicitudes de creación/actualización de permisos de rol.
***********/

using Shared.Kernel.Interfaces;
using Shared.Time;
using Usuario.Application.SEG_Rol.Dtos;
using Usuario.Domain.SEG_Rol.Parameters;

namespace Usuario.Application.SEG_Rol.Mappers
{
    public class CrearPermisosRolRequestMapper : IMapper<CrearPermisosRolRequest, CrearPermisosRolParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public CrearPermisosRolRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public CrearPermisosRolParameters Map(CrearPermisosRolRequest source)
        {
            var permisos = source.lstModulos
                .SelectMany(modulo => modulo.lstAcciones.Select(accion => new PermisoRolParameter
                {
                    ModuloId = modulo.nModuloId,
                    AccionId = accion.nAccionId,
                    Permitir = accion.bPermitir
                }))
                .ToList();

            return new CrearPermisosRolParameters
            {
                RolId = source.nRolId,
                UsuarioModificacionId = source.nUsuarioModificacionId,
                FechaOperacion = _timeProvider.NowPeru,
                Permisos = permisos
            };
        }
    }
}
