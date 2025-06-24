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
                nDirectorId = source.nDirectorId,
                nEmpresaId = source.nEmpresaId,
                nTipoDocumentoId = source.nTipoDocumentoId,
                sNumeroDocumento = source.sNumeroDocumento,
                sNombres = source.sNombres,
                sApellidos = source.sApellidos,
                dtFechaNacimiento = source.dtFechaNacimiento,
                nGeneroId = source.nGeneroId,
                nDistritoId = source.nDistritoId,
                nProvinciaId = source.nProvinciaId,
                nDepartamentoId = source.nDepartamentoId,
                sDireccion = source.sDireccion,
                sTelefono = source.sTelefono,
                sTelefonoSecundario = source.sTelefonoSecundario,
                sTelefonoTerciario = source.sTelefonoTerciario,
                sCorreo = source.sCorreo,
                sCorreoSecundario = source.sCorreoSecundario,
                sCorreoTerciario = source.sCorreoTerciario,
                nCargoId = source.nCargoId,
                nTipoDirectorId = source.nTipoDirectorId,
                nSectorId = source.nIdSector,
                sProfesion = source.sProfesion,
                dDieta = source.dDieta,
                nEspecialidadId = source.nEspecialidadId,
                dtFechaNombramiento = source.dtFechaNombramiento,
                dtFechaDesignacion = source.dtFechaDesignacion,
                dtFechaRenuncia = source.dtFechaRenuncia,
                sComentario = source.sComentario,
                dtFechaModificacion = _timeProvider.NowPeru,
                nUsuarioModificacionId = source.nUsuarioModificacionId
            };
        }
    }
}
