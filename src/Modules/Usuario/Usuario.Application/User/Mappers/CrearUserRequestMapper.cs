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
                Username = source.Username,
                PasswordHash = source.Password,
                CorreoElectronico = source.CorreoElectronico,
                FechaRegistro = _timeProvider.NowPeru,
                UsuarioRegistroId = source.UsuarioRegistroId,
                ApellidoPaterno = source.ApellidoPaterno,
                ApellidoMaterno = source.ApellidoMaterno,
                Nombres = source.Nombres
            };
        }
    }
}
