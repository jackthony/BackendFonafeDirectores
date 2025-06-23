using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Ubigeo.Results;
using Empresa.Presentation.Ubigeo.Responses;

namespace Empresa.Presentation.Ubigeo.Mappers
{
    public class ObtenerUbigeoResponsePorIdPresenter : IPresenterDelivery<UbigeoResult, ItemResponse<UbigeoResponse>>
    {
        public ItemResponse<UbigeoResponse> Present(UbigeoResult input)
        {
            return new ItemResponse<UbigeoResponse>
            {
                IsSuccess = true,
                Item = UbigeoResponseMapper.ToResponse(input),
            };
        }
    }
}
