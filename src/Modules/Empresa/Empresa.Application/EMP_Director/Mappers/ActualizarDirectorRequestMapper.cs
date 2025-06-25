using Shared.Kernel.Interfaces;
using Empresa.Application.Director.Dtos;
using Empresa.Domain.Director.Parameters;
using Shared.Time;

namespace Empresa.Application.Director.Mappers
{
    public class ActualizarDirectorRequestMapper : IMapper<ActualizarDirectorRequest, ActualizarDirectorParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public ActualizarDirectorRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }
        public ActualizarDirectorParameters Map(ActualizarDirectorRequest source)
        {
            return new ActualizarDirectorParameters
            {
                nDirectorId = source.nIdRegistro,
                nEmpresaId = source.nIdEmpresa,
                nDepartamentoId = int.TryParse(source.sDepartamento, out var departamentoId) ? departamentoId : (int?)null,
                nProvinciaId = int.TryParse(source.sProvincia, out var provinciaId) ? provinciaId : (int?)null,
                nDistritoId = int.TryParse(source.sDistrito, out var distritoId) ? distritoId : (int?)null,
                sDireccion = source.sDireccion,
                sTelefono = source.sTelefono,
                sTelefonoSecundario = source.sTelefonoSecundario,
                sTelefonoTerciario = source.sTelefonoTerciario,
                sCorreo = source.sCorreo,
                sCorreoSecundario = source.sCorreoSecundario,
                sCorreoTerciario = source.sCorreoTerciario,
                nCargoId = source.nCargo,
                nTipoDirectorId = source.nTipoDirector,
                sProfesion = source.sProfesion,
                nSectorId = source.nIdSector,
                dDieta = source.mDieta,
                nEspecialidadId = source.nEspecialidad,
                dtFechaNombramiento = source.dFechaNombramiento,
                dtFechaDesignacion = source.dFechaDesignacion,
                sComentario = source.sComentario,
                dtFechaModificacion = _timeProvider.NowPeru,
                nUsuarioModificacionId = source.nUsuarioModificacion,
            };
        }
    }
}
