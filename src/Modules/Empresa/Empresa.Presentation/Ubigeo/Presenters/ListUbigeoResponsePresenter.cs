using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Ubigeo.Results;
using Empresa.Presentation.Ubigeo.Responses;

namespace Empresa.Presentation.Ubigeo.Mappers
{
    public class ListUbigeoResponsePresenter : IPresenterDelivery<List<UbigeoResult>, LstItemResponse<UbigeoResponse>>
    {
        public LstItemResponse<UbigeoResponse> Present(List<UbigeoResult> input)
        {
            return new LstItemResponse<UbigeoResponse>
            {
                LstItem = UbigeoResponseMapper.ToListResponse(input),
                IsSuccess = true
            };
        }
    }
}
