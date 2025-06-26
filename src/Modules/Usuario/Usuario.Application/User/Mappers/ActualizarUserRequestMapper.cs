using Shared.Kernel.Interfaces;
using Usuario.Application.User.Dtos;
using Usuario.Domain.User.Parameters;

namespace Usuario.Application.User.Mappers
{
    public class ActualizarUserRequestMapper : IMapper<ActualizarUserRequest, ActualizarUserParameters>
    {
        public ActualizarUserParameters Map(ActualizarUserRequest source)
        {
            return new ActualizarUserParameters
            {
                UsuarioId = source.nIdUsuario,
                UsuarioModificacionId = source.nUsuarioModificacion,
                RolId = source.nIdRol,
                Estado = source.nEstado,
                CargoId = source.nIdCargo,
                nTipoPersonal = source.nTipoPersonal,
                FechaModificacion = DateTime.UtcNow
            };
        }
    }
}
