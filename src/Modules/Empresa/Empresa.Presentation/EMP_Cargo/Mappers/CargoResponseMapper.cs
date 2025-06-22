using Empresa.Domain.Cargo.Results;
using Empresa.Presentation.Cargo.Responses;

namespace Empresa.Presentation.Cargo.Mappers
{
    public static class CargoResponseMapper
    {
        public static CargoResponse ToResponse(CargoResult dto) => new()
        {
        };

        public static IEnumerable<CargoResponse> ToListResponse(IEnumerable<CargoResult> items)
            => items.Select(ToResponse);
    }
}
