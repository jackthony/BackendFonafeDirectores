using Empresa.Application.EMP_Cargo.Dtos;
using Empresa.Domain.EMP_Cargo.Models;
using Shared.Kernel.Interfaces;
using Shared.Time;

namespace Empresa.Application.EMP_Cargo.Mappers
{
    public class ActualizarCargoMapper : IMapper<ActualizarCargoRequest, ActualizarCargoData>
    {
        private readonly ITimeProvider _timeProvider;

        public ActualizarCargoMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public ActualizarCargoData Map(ActualizarCargoRequest request)
        {
            return new ActualizarCargoData
            {
                CargoId = request.CargoId,
                UsuarioModificacionId = request.UsuarioModificacionId,
                FechaModificacion = _timeProvider.NowPeru,
                NombreCargo = request.NombreCargo,
                IsActivo = request.IsActivo
            };
        }
    }
}
