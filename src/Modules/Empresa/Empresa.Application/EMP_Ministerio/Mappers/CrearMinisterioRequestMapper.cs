using Shared.Kernel.Interfaces;
using Shared.Time;
using Empresa.Application.Ministerio.Dtos;
using Empresa.Domain.Ministerio.Parameters;

namespace Empresa.Application.Ministerio.Mappers
{
    public class CrearMinisterioRequestMapper : IMapper<CrearMinisterioRequest, CrearMinisterioParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public CrearMinisterioRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public CrearMinisterioParameters Map(CrearMinisterioRequest source)
        {
            return new CrearMinisterioParameters
            {
                Ministerioname = source.Ministerioname,
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
