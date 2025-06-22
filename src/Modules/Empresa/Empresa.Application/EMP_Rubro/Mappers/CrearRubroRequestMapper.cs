using Shared.Kernel.Interfaces;
using Shared.Time;
using Empresa.Application.Rubro.Dtos;
using Empresa.Domain.Rubro.Parameters;

namespace Empresa.Application.Rubro.Mappers
{
    public class CrearRubroRequestMapper : IMapper<CrearRubroRequest, CrearRubroParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public CrearRubroRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public CrearRubroParameters Map(CrearRubroRequest source)
        {
            return new CrearRubroParameters
            {
                NombreRubro = source.NombreRubro,
                UsuarioRegistroId = source.UsuarioRegistroId,
                FechaRegistro = _timeProvider.NowPeru
            };
        }
    }
}
