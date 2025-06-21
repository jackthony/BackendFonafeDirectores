using Cargo.Application.Dtos;
using Cargo.Presentation.Dtos.Responses;

namespace Cargo.Presentation.Mappers
{
    public static class CargoClientMapper
    {
        public static CargoClientDto ToClientDto(CargoDto dto) => new()
        {
        };

        public static IEnumerable<CargoClientDto> ToClientDtos(IEnumerable<CargoDto> items)
            => items.Select(ToClientDto);
    }
}
