using Shared.Kernel.Interfaces;
using Empresa.Application.Especialidad.Dtos;
using Empresa.Domain.Especialidad.Parameters;

namespace Empresa.Application.Especialidad.Mappers
{
    public class EliminarEspecialidadRequestMapper : IMapper<EliminarEspecialidadRequest, EliminarEspecialidadParameters>
    {
        public EliminarEspecialidadParameters Map(EliminarEspecialidadRequest source)
        {
            return new EliminarEspecialidadParameters
            {
                EspecialidadId = source.EspecialidadId,
                UsuarioModificacionId = source.UsuarioModificacionId,
                FechaModificacion = DateTime.UtcNow
            };
        }
    }
}
