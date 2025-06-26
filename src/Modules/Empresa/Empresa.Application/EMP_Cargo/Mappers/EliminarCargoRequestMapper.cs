using Shared.Kernel.Interfaces;
using Empresa.Application.Cargo.Dtos;
using Empresa.Domain.Cargo.Parameters;

namespace Empresa.Application.Cargo.Mappers
{
    public class EliminarCargoRequestMapper : IMapper<EliminarCargoRequest, EliminarCargoParameters>
    {
        public EliminarCargoParameters Map(EliminarCargoRequest source)
        {
            return new EliminarCargoParameters
            {
                CargoId = source.nIdCargo,
                UsuarioModificacionId = source.nUsuarioModificacion,
                FechaModificacion = DateTime.UtcNow
            };

        }
    }
}
