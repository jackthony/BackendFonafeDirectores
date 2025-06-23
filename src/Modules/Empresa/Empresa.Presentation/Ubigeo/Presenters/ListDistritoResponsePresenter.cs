using Empresa.Domain.Ubigeo.Results;
using Empresa.Presentation.Ubigeo.Mappers;
using Empresa.Presentation.Ubigeo.Responses;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Empresa.Presentation.Ubigeo.Presenters
{
    public class ListDistritoResponsePresenter : IPresenterDelivery<List<DistritoResult>, LstItemResponse<DistritoResponse>>
    {
        public LstItemResponse<DistritoResponse> Present(List<DistritoResult> input)
        {
            return new LstItemResponse<DistritoResponse>
            {
                LstItem = DistritoResponseMapper.ToListResponse(input),
                IsSuccess = true
            };
        }
    }
}
