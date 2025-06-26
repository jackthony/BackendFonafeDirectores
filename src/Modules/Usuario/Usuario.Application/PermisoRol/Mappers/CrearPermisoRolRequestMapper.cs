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
