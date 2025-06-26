using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Ministerio.Results;
using Empresa.Presentation.Ministerio.Responses;

namespace Empresa.Presentation.Ministerio.Mappers
{
    public class ObtenerMinisterioResponsePorIdPresenter : IPresenterDelivery<MinisterioResult, ItemResponse<MinisterioResponse>>
    {
        public ItemResponse<MinisterioResponse> Present(MinisterioResult input)
        {
            return new ItemResponse<MinisterioResponse>
            {
                IsSuccess = true,
                Item = MinisterioResponseMapper.ToResponse(input),
            };
        }
    }
}
