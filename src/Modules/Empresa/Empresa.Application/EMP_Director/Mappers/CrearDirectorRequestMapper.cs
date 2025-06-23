using Shared.Kernel.Interfaces;
using Shared.Time;
using Empresa.Application.Director.Dtos;
using Empresa.Domain.Director.Parameters;

namespace Empresa.Application.Director.Mappers
{
    public class CrearDirectorRequestMapper : IMapper<CrearDirectorRequest, CrearDirectorParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public CrearDirectorRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public CrearDirectorParameters Map(CrearDirectorRequest source)
        {
            return new CrearDirectorParameters
            {
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
                nSectorId = source.nSectorId,
                sProfesion = source.sProfesion,
                dDieta = source.dDieta,
                nEspecialidadId = source.nEspecialidadId,
                dtFechaNombramiento = source.dtFechaNombramiento,
                dtFechaDesignacion = source.dtFechaDesignacion,
                dtFechaRenuncia = source.dtFechaRenuncia,
                sComentario = source.sComentario,
                dtFechaRegistro = _timeProvider.NowPeru,
                nUsuarioRegistroId = source.nUsuarioRegistroId
            };
        }
    }
}
