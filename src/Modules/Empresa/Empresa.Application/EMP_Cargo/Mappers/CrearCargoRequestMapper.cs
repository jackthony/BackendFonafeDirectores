using Shared.Kernel.Interfaces;
using Shared.Time;
using Empresa.Application.Cargo.Dtos;
using Empresa.Domain.Cargo.Parameters;

namespace Empresa.Application.Cargo.Mappers
{
    public class CrearCargoRequestMapper : IMapper<CrearCargoRequest, CrearCargoParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public CrearCargoRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public CrearCargoParameters Map(CrearCargoRequest source)
        {
            return new CrearCargoParameters
            {
                NombreCargo = source.sNombreCargo,
                UsuarioRegistroId = source.nUsuarioRegistro,
                FechaRegistro = _timeProvider.NowPeru
            };
        }
    }
}
