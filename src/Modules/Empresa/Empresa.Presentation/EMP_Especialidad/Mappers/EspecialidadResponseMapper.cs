using Empresa.Domain.Especialidad.Results;
using Empresa.Presentation.Especialidad.Responses;

namespace Empresa.Presentation.Especialidad.Mappers
{
    public static class EspecialidadResponseMapper
    {
        public static EspecialidadResponse ToResponse(EspecialidadResult dto) => new()
        {
            nIdEspecialidad = dto.EspecialidadId,
            sNombreEspecialidad = dto.NombreEspecialidad,
            bActivo = dto.IsActivo,
            dtFechaRegistro = dto.FechaRegistro,
            nUsuarioRegistro = dto.UsuarioRegistroId,
            dtFechaModificacion = dto.FechaModificacion,
            nUsuarioModificacion = dto.UsuarioModificacionId
        };

        public static IEnumerable<EspecialidadResponse> ToListResponse(IEnumerable<EspecialidadResult> items)
            => items.Select(ToResponse);
    }
}
