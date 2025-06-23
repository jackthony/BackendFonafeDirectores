using Shared.Kernel.Interfaces;
using Usuario.Application.Rol.Dtos;
using Usuario.Domain.Rol.Parameters;

namespace Usuario.Application.Rol.Mappers
{
    public class ActualizarRolRequestMapper : IMapper<ActualizarRolRequest, ActualizarRolParameters>
    {
        public ActualizarRolParameters Map(ActualizarRolRequest source)
        {
            return new ActualizarRolParameters
            {
                RolId = source.nIdRol,
                NombreRol = source.sNombreRol,
                FechaModificacion = source.dtFechaModificacion,
                UsuarioModificacionId = source.nUsuarioModificacion,
            };
        }
    }
}
