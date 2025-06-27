using Empresa.Domain.TipoDirector.Results;
using Empresa.Presentation.TipoDirector.Responses;

namespace Empresa.Presentation.TipoDirector.Mappers
{
    public static class TipoDirectorResponseMapper
    {
        public static TipoDirectorResponse ToResponse(TipoDirectorResult dto) => new()
        {
            nIdTipoDirector = dto.TipoDirectorId,
            sNombreTipoDirector = dto.NombreTipoDirector,
            bActivo = dto.IsActivo,
            dtFechaRegistro = dto.FechaRegistro,
            nUsuarioRegistro = dto.UsuarioRegistroId,
            dtFechaModificacion = dto.FechaModificacion,
            nUsuarioModificacion = dto.UsuarioModificacionId
        };

        public static IEnumerable<TipoDirectorResponse> ToListResponse(IEnumerable<TipoDirectorResult> items)
            => items.Select(ToResponse);
    }
}
