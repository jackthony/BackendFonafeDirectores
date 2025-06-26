using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Cargo.Results;
using Empresa.Presentation.Cargo.Responses;

namespace Empresa.Presentation.Cargo.Mappers
{
    public class ListCargoResponsePresenter : IPresenterDelivery<List<CargoResult>, LstItemResponse<CargoResponse>>
    {
        public LstItemResponse<CargoResponse> Present(List<CargoResult> input)
        {
            return new LstItemResponse<CargoResponse>
            {
                LstItem = CargoResponseMapper.ToListResponse(input),
                IsSuccess = true
            };
        }
    }
}
