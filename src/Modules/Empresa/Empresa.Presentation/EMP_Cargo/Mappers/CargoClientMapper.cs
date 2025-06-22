using Empresa.Application.EMP_Cargo.Dtos;
using Empresa.Presentation.EMP_Cargo.Dtos.Responses;

namespace Empresa.Presentation.EMP_Cargo.Mappers
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
