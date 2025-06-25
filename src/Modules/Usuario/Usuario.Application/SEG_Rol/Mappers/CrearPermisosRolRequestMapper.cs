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
