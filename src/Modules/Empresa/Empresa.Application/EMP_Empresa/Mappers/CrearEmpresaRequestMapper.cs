using Shared.Kernel.Interfaces;
using Shared.Time;
using Empresa.Application.Empresa.Dtos;
using Empresa.Domain.Empresa.Parameters;

namespace Empresa.Application.Empresa.Mappers
{
    public class CrearEmpresaRequestMapper : IMapper<CrearEmpresaRequest, CrearEmpresaParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public CrearEmpresaRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public CrearEmpresaParameters Map(CrearEmpresaRequest source)
        {
            return new CrearEmpresaParameters
            {
                Empresaname = source.Empresaname,
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
