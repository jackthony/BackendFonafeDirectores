using Shared.Kernel.Interfaces;
using Shared.Time;
using Usuario.Application.Rol.Dtos;
using Usuario.Domain.Rol.Parameters;

namespace Usuario.Application.Rol.Mappers
{
    public class CrearRolRequestMapper : IMapper<CrearRolRequest, CrearRolParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public CrearRolRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public CrearRolParameters Map(CrearRolRequest source)
        {
            return new CrearRolParameters
            {
                Rolname = source.Rolname,
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
