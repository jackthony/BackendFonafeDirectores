using Shared.Kernel.Interfaces;
using Empresa.Application.Especialidad.Dtos;
using Empresa.Domain.Especialidad.Parameters;
using Shared.Time;

namespace Empresa.Application.Especialidad.Mappers
{
    public class ActualizarEspecialidadRequestMapper : IMapper<ActualizarEspecialidadRequest, ActualizarEspecialidadParameters>
    {
        private readonly ITimeProvider _timeProvider;
        public ActualizarEspecialidadRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }
        public ActualizarEspecialidadParameters Map(ActualizarEspecialidadRequest source)
        {
            return new ActualizarEspecialidadParameters
            {
                EspecialidadId = source.nIdEspecialidad,
                NombreEspecialidad = source.sNombreEspecialidad,
                UsuarioModificacionId = source.nUsuarioModificacion,
                FechaModificacion = _timeProvider.NowPeru
            };
        }
    }
}
