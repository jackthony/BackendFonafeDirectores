using Shared.Kernel.Interfaces;
using Empresa.Application.TipoDirector.Dtos;
using Empresa.Domain.TipoDirector.Parameters;

namespace Empresa.Application.TipoDirector.Mappers
{
    public class EliminarTipoDirectorRequestMapper : IMapper<EliminarTipoDirectorRequest, EliminarTipoDirectorParameters>
    {
        public EliminarTipoDirectorParameters Map(EliminarTipoDirectorRequest source)
        {
            return new EliminarTipoDirectorParameters
            {
                TipoDirectorId = source.TipoDirectorId,
                UsuarioModificacionId = source.UsuarioModificacionId,
                FechaModificacion = DateTime.UtcNow
            };

        }
    }
}
