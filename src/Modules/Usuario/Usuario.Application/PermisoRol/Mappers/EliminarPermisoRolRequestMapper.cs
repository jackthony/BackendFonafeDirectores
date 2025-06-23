using Shared.Kernel.Interfaces;
using Usuario.Application.PermisoRol.Dtos;
using Usuario.Domain.PermisoRol.Parameters;

namespace Usuario.Application.PermisoRol.Mappers
{
    public class EliminarPermisoRolRequestMapper : IMapper<EliminarPermisoRolRequest, EliminarPermisoRolParameters>
    {
        public EliminarPermisoRolParameters Map(EliminarPermisoRolRequest source)
        {
            return new EliminarPermisoRolParameters
            {
            };
        }
    }
}
