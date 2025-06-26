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
                NombreRol = source.sNombreRol,
                UsuarioRegistroId = source.nUsuarioRegistro,
                FechaRegistro = _timeProvider.NowPeru,
            };
        }
    }
}
