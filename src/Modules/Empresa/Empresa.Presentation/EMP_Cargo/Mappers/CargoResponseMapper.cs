using Empresa.Domain.Cargo.Results;
using Empresa.Presentation.Cargo.Responses;

namespace Empresa.Presentation.Cargo.Mappers
{
    public static class CargoResponseMapper
    {
        public static CargoResponse ToResponse(CargoResult dto) => new()
        {
            nIdCargo = dto.CargoId,
            sNombreCargo = dto.NombreCargo,
            bActivo = dto.IsActivo,
            dtFechaRegistro = dto.FechaRegistro,
            nUsuarioRegistro = dto.UsuarioRegistroId,
            dtFechaModificacion = dto.FechaModificacion,
            nUsuarioModificacion = dto.UsuarioModificacionId
        };

        public static IEnumerable<CargoResponse> ToListResponse(IEnumerable<CargoResult> items)
            => items.Select(ToResponse);
    }
}
