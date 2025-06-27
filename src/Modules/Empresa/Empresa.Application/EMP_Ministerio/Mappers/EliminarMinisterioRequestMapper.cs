using Shared.Kernel.Interfaces;
using Empresa.Application.Ministerio.Dtos;
using Empresa.Domain.Ministerio.Parameters;

namespace Empresa.Application.Ministerio.Mappers
{
    public class EliminarMinisterioRequestMapper : IMapper<EliminarMinisterioRequest, EliminarMinisterioParameters>
    {
        public EliminarMinisterioParameters Map(EliminarMinisterioRequest source)
        {
            return new EliminarMinisterioParameters
            {
                MinisterioId = source.nIdMinisterio,
                UsuarioModificacionId = source.nUsuarioModificacion,
                FechaModificacion = DateTime.UtcNow
            };
        }
    }
}
