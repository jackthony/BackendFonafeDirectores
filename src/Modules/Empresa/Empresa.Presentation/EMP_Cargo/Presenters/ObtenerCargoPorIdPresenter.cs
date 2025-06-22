using Empresa.Application.EMP_Cargo.Dtos;
using Empresa.Presentation.EMP_Cargo.Dtos.Responses;
using Empresa.Presentation.EMP_Cargo.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Empresa.Presentation.EMP_Cargo.Presenters
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
