using Shared.Kernel.Interfaces;
using Shared.Time;
using Empresa.Application.Especialidad.Dtos;
using Empresa.Domain.Especialidad.Parameters;

namespace Empresa.Application.Especialidad.Mappers
{
    public class CrearEspecialidadRequestMapper : IMapper<CrearEspecialidadRequest, CrearEspecialidadParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public CrearEspecialidadRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public CrearEspecialidadParameters Map(CrearEspecialidadRequest source)
        {
            return new CrearEspecialidadParameters
            {
                Especialidadname = source.Especialidadname,
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
