using Cargo.Application.Dtos;
using Cargo.Presentation.Dtos.Responses;
using Cargo.Presentation.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Cargo.Presentation.Presenters
{
    public class ObtenerCargoPorIdPresenter : IPresenter<
        int,
        long,
        CargoDto,
        ItemResponse<CargoClientDto>>
    {
        public long ToRequest(int clientRequest)
        {
            throw new NotImplementedException();
        }

        public ItemResponse<CargoClientDto> ToResponse(CargoDto dto)
        {
            return new ItemResponse<CargoClientDto>
            {
                IsSuccess = true,
                Item = CargoClientMapper.ToClientDto(dto),
            };
        }
    }
}
