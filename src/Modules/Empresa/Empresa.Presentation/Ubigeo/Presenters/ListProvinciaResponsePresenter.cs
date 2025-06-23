using Empresa.Domain.Ubigeo.Results;
using Empresa.Presentation.Ubigeo.Mappers;
using Empresa.Presentation.Ubigeo.Responses;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Empresa.Presentation.Ubigeo.Presenters
{
    public class ListProvinciaResponsePresenter : IPresenterDelivery<List<ProvinciaResult>, LstItemResponse<ProvinciaResponse>>
    {
        public LstItemResponse<ProvinciaResponse> Present(List<ProvinciaResult> input)
        {
            return new LstItemResponse<ProvinciaResponse>
            {
                LstItem = ProvinciaResponseMapper.ToListResponse(input),
                IsSuccess = true
            };
        }
    }
}
