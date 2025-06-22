using Empresa.Application.EMP_Cargo.Dtos;
using Empresa.Domain.EMP_Cargo.Models;
using Shared.Kernel.Interfaces;
using Shared.Time;

namespace Empresa.Application.EMP_Cargo.Mappers
{
    public class EliminarCargoMapper : IMapper<EliminarCargoRequest, EliminarCargoData>
    {
        private readonly ITimeProvider _timeProvider;

        public EliminarCargoMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public EliminarCargoData Map(EliminarCargoRequest request)
        {
            return new EliminarCargoData
            {
                CargoId = request.CargoId,
                UsuarioModificacionId = request.UsuarioModificacionId,
                FechaModificacion = _timeProvider.NowPeru
            };
        }
    }
}
