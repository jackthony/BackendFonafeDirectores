using Shared.Kernel.Interfaces;
using Empresa.Application.Cargo.Dtos;
using Empresa.Domain.Cargo.Parameters;
using Shared.Time;

namespace Empresa.Application.Cargo.Mappers
{
    public class ActualizarCargoRequestMapper : IMapper<ActualizarCargoRequest, ActualizarCargoParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public ActualizarCargoRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public ActualizarCargoParameters Map(ActualizarCargoRequest source)
        {
            return new ActualizarCargoParameters
            {
                CargoId = source.CargoId,
                NombreCargo = source.NombreCargo,
                UsuarioModificacionId = source.UsuarioModificacionId,
                FechaModificacion = _timeProvider.NowPeru
            };
        }
    }

}
