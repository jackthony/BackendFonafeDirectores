using Shared.Kernel.Interfaces;
using Usuario.Application.Rol.Dtos;
using Usuario.Domain.Rol.Parameters;

namespace Usuario.Application.Rol.Mappers
{
    public class EliminarRolRequestMapper : IMapper<EliminarRolRequest, EliminarRolParameters>
    {
        public EliminarRolParameters Map(EliminarRolRequest source)
        {
            return new EliminarRolParameters()
            {
                CargoId = source.nRolId,
                UsuarioModificacion = source.nIdUsuarioModificacion,
                FechaModificacion = source.dtFechaModificacion
            };
        }
    }
}
