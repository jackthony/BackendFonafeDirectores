using Shared.Kernel.Interfaces;
using Usuario.Application.PermisoRol.Dtos;
using Usuario.Domain.PermisoRol.Parameters;

namespace Usuario.Application.PermisoRol.Mappers
{
    public class ActualizarPermisoRolRequestMapper : IMapper<ActualizarPermisoRolRequest, ActualizarPermisoRolParameters>
    {
        public ActualizarPermisoRolParameters Map(ActualizarPermisoRolRequest source)
        {
            return new ActualizarPermisoRolParameters
            {
            };
        }
    }
}
