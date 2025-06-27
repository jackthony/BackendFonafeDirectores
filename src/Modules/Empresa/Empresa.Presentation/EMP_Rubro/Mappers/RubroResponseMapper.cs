using Empresa.Domain.Rubro.Results;
using Empresa.Presentation.Rubro.Responses;

namespace Empresa.Presentation.Rubro.Mappers
{
    public static class RubroResponseMapper
    {
        public static RubroResponse ToResponse(RubroResult dto) => new()
        {
            nIdRubro = dto.RubroId,
            sNombreRubro = dto.NombreRubro,
            bActivo = dto.IsActivo,
            dtFechaRegistro = dto.FechaRegistro,
            nUsuarioRegistro = dto.UsuarioRegistroId,
            dtFechaModificacion = dto.FechaModificacion,
            nUsuarioModificacion = dto.UsuarioModificacionId
        };

        public static IEnumerable<RubroResponse> ToListResponse(IEnumerable<RubroResult> items)
            => items.Select(ToResponse);
    }
}
