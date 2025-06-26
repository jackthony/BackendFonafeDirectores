using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Dieta.Results;
using Empresa.Presentation.Dieta.Responses;

namespace Empresa.Presentation.Dieta.Presenters
{
    public class ObtenerDietaResponsePresenter : IPresenterDelivery<DietaResult, ItemResponse<DietaResponse>>
    {
        public ItemResponse<DietaResponse> Present(DietaResult input)
        {
            return new ItemResponse<DietaResponse>
            {
                IsSuccess = true,
                Item = DietaResponseMapper.ToResponse(input)
            };
        }
    }
}
