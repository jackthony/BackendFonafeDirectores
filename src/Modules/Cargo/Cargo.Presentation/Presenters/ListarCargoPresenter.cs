using Cargo.Application.Dtos;
using Cargo.Presentation.Dtos.Request;
using Cargo.Presentation.Dtos.Responses;
using Cargo.Presentation.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Cargo.Presentation.Presenters
{
    public class ListarCargoPresenter : IPresenter<
        ListarCargoClientRequest,
        ListarCargoRequest,
        List<CargoDto>,
        LstItemResponse<CargoClientDto>>
    {
        public ListarCargoRequest ToRequest(ListarCargoClientRequest clientRequest)
        {
            throw new NotImplementedException();
        }

        public LstItemResponse<CargoClientDto> ToResponse(List<CargoDto> dto)
        {
            return new LstItemResponse<CargoClientDto>
            {
                LstItem = CargoClientMapper.ToClientDtos(dto),
                IsSuccess = true
            };
        }
    }
}
