using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Rubro.Results;
using Empresa.Presentation.Rubro.Responses;

namespace Empresa.Presentation.Rubro.Mappers
{
    public class ObtenerRubroResponsePorIdPresenter : IPresenterDelivery<RubroResult, ItemResponse<RubroResponse>>
    {
        public ItemResponse<RubroResponse> Present(RubroResult input)
        {
            return new ItemResponse<RubroResponse>
            {
                IsSuccess = true,
                Item = RubroResponseMapper.ToResponse(input),
            };
        }
    }
}
