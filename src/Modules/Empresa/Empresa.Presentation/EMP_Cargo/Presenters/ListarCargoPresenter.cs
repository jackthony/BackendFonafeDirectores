using Empresa.Application.EMP_Cargo.Dtos;
using Empresa.Presentation.EMP_Cargo.Dtos.Request;
using Empresa.Presentation.EMP_Cargo.Dtos.Responses;
using Empresa.Presentation.EMP_Cargo.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Empresa.Presentation.EMP_Cargo.Presenters
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
