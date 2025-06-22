using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Ministerio.Results;
using Empresa.Presentation.Ministerio.Responses;

namespace Empresa.Presentation.Ministerio.Mappers
{
    public class ListMinisterioResponsePresenter : IPresenterDelivery<List<MinisterioResult>, LstItemResponse<MinisterioResponse>>
    {
        public LstItemResponse<MinisterioResponse> Present(List<MinisterioResult> input)
        {
            return new LstItemResponse<MinisterioResponse>
            {
                LstItem = MinisterioResponseMapper.ToListResponse(input),
                IsSuccess = true
            };
        }
    }
}
