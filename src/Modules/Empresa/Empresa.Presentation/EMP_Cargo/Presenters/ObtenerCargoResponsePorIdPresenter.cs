using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Cargo.Results;
using Empresa.Presentation.Cargo.Responses;

namespace Empresa.Presentation.Cargo.Mappers
{
    public class ObtenerCargoResponsePorIdPresenter : IPresenterDelivery<CargoResult, ItemResponse<CargoResponse>>
    {
        public ItemResponse<CargoResponse> Present(CargoResult input)
        {
            return new ItemResponse<CargoResponse>
            {
                IsSuccess = true,
                Item = CargoResponseMapper.ToResponse(input),
            };
        }
    }
}
