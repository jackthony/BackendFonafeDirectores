using Empresa.Domain.Ministerio.Results;
using Empresa.Presentation.Ministerio.Responses;

namespace Empresa.Presentation.Ministerio.Mappers
{
    public static class MinisterioResponseMapper
    {
        public static MinisterioResponse ToResponse(MinisterioResult dto) => new()
        {
            nIdMinisterio = dto.MinisterioId,
            sNombreMinisterio = dto.NombreMinisterio,
            bActivo = dto.IsActivo,
            dtFechaRegistro = dto.FechaRegistro,
            nUsuarioRegistro = dto.UsuarioRegistroId,
            dtFechaModificacion = dto.FechaModificacion,
            nUsuarioModificacion = dto.UsuarioModificacionId
        };

        public static IEnumerable<MinisterioResponse> ToListResponse(IEnumerable<MinisterioResult> items)
            => items.Select(ToResponse);
    }
}
