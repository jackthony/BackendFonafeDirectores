using Shared.Kernel.Interfaces;
using Shared.Time;
using Usuario.Application.User.Dtos;
using Usuario.Domain.User.Parameters;

namespace Usuario.Application.User.Mappers
{
    public class CrearUserRequestMapper : IMapper<CrearUserRequest, CrearUserParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public CrearUserRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public CrearUserParameters Map(CrearUserRequest source)
        {
            return new CrearUserParameters
            {
                PasswordHash = source.sContrasena,
                CorreoElectronico = source.sCorreoElectronico,
                FechaRegistro = _timeProvider.NowPeru,
                UsuarioRegistroId = source.nUsuarioRegistro,
                CargoId = source.nIdCargo,
                RolId = source.nIdRol,
                Estado = source.nEstado,
                ApellidoPaterno = source.sApellidoPaterno,
                ApellidoMaterno = source.sApellidoMaterno,
                Nombres = source.sNombres
            };
        }
    }
}
