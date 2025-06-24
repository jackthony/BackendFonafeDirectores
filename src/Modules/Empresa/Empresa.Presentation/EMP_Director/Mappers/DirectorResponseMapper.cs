using Empresa.Domain.Director.Results;
using Empresa.Presentation.Director.Responses;

namespace Empresa.Presentation.Director.Mappers
{
    public static class DirectorResponseMapper
    {
        public static DirectorResponse ToResponse(DirectorResult dto) => new DirectorResponse
        {
            nIdRegistro = dto.nIdRegistro,
            nIdEmpresa = dto.nIdEmpresa,
            nTipoDocumento = dto.nTipoDocumento,
            sNumeroDocumento = dto.sNumeroDocumento,
            sNombres = dto.sNombres,
            sApellidos = dto.sApellidos,
            dFechaNacimiento = dto.dFechaNacimiento,
            nGenero = dto.nGenero,
            sDistrito = dto.sDistrito,
            sProvincia = dto.sProvincia,
            sDepartamento = dto.sDepartamento,
            sDireccion = dto.sDireccion,
            sTelefono = dto.sTelefono,
            sTelefonoSecundario = dto.sTelefonoSecundario,
            sTelefonoTerciario = dto.sTelefonoTerciario,
            sCorreo = dto.sCorreo,
            sCorreoSecundario = dto.sCorreoSecundario,
            sCorreoTerciario = dto.sCorreoTerciario,
            nCargo = dto.nCargo,
            nTipoDirector = dto.nTipoDirector,
            nIdSector = dto.nIdSector,
            sProfesion = dto.sProfesion,
            mDieta = dto.mDieta,
            nEspecialidad = dto.nEspecialidad,
            dFechaNombramiento = dto.dFechaNombramiento,
            dFechaDesignacion = dto.dFechaDesignacion,
            dFechaRenuncia = dto.dFechaRenuncia,
            sComentario = dto.sComentario,
            dtFechaRegistro = dto.dtFechaRegistro,
            nUsuarioRegistro = dto.nUsuarioRegistro,
            dtFechaModificacion = dto.dtFechaModificacion,
            nUsuarioModificacion = dto.nUsuarioModificacion
        };


        public static IEnumerable<DirectorResponse> ToListResponse(IEnumerable<DirectorResult> items)
            => items.Select(ToResponse);
    }
}
