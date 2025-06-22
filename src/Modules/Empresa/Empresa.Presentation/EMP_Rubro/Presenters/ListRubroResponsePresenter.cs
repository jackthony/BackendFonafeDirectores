using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Rubro.Results;
using Empresa.Presentation.Rubro.Responses;

namespace Empresa.Presentation.Rubro.Mappers
{
    public class ListRubroResponsePresenter : IPresenterDelivery<List<RubroResult>, LstItemResponse<RubroResponse>>
    {
        public LstItemResponse<RubroResponse> Present(List<RubroResult> input)
        {
            return new LstItemResponse<RubroResponse>
            {
                LstItem = RubroResponseMapper.ToListResponse(input),
                IsSuccess = true
            };
        }
    }
}
