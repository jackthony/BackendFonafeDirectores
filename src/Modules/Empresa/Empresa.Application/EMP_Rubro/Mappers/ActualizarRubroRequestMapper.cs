using Shared.Kernel.Interfaces;
using Empresa.Application.Rubro.Dtos;
using Empresa.Domain.Rubro.Parameters;
using Shared.Time;

namespace Empresa.Application.Rubro.Mappers
{
    public class ActualizarRubroRequestMapper : IMapper<ActualizarRubroRequest, ActualizarRubroParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public ActualizarRubroRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public ActualizarRubroParameters Map(ActualizarRubroRequest source)
        {
            return new ActualizarRubroParameters
            {
                RubroId = source.RubroId,
                NombreRubro = source.NombreRubro,
                UsuarioModificacionId = source.UsuarioModificacionId,
                FechaModificacion = _timeProvider.NowPeru
            };
        }
    }
}
