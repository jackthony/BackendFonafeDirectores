using Shared.Kernel.Interfaces;
using Empresa.Application.Rubro.Dtos;
using Empresa.Domain.Rubro.Parameters;

namespace Empresa.Application.Rubro.Mappers
{
    public class EliminarRubroRequestMapper : IMapper<EliminarRubroRequest, EliminarRubroParameters>
    {
        public EliminarRubroParameters Map(EliminarRubroRequest source)
        {
            return new EliminarRubroParameters
            {
                RubroId = source.nIdRubro,
                UsuarioModificacionId = source.nUsuarioModificacion,
                FechaModificacion = DateTime.UtcNow
            };
        }
    }
}
