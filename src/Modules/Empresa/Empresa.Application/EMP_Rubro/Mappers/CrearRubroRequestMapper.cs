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
                Rubroname = source.Rubroname,
                PasswordHash = source.Password,
                CorreoElectronico = source.CorreoElectronico,
                FechaRegistro = _timeProvider.NowPeru,
                EmpresaRegistroId = source.EmpresaRegistroId,
                ApellidoPaterno = source.ApellidoPaterno,
                ApellidoMaterno = source.ApellidoMaterno,
                Nombres = source.Nombres
            };
        }
    }
}
