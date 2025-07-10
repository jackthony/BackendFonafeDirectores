/***********
* Nombre del archivo: CargoResponseMapper.cs
* Descripción:        **Clase estática que actúa como mapeador** para transformar objetos de dominio `CargoResult`
*                     en objetos de respuesta `CargoResponse`. Proporciona métodos para convertir un solo resultado
*                     de cargo o una colección de ellos, facilitando la adaptación de los datos de la capa
*                     de dominio a la capa de presentación.
* Autor:              Daniel Alva
* Fecha de creación:  11/07/2025
* Última modificación:11/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase mapeadora estática para respuestas de cargo.
***********/

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
