using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Archivo.Domain.Archivo.Results;
using Archivo.Presentation.Archivo.Responses;

namespace Archivo.Presentation.Archivo.Mappers
{
    public class ListArchivoResponsePresenter : IPresenterDelivery<List<ArchivoResult>, LstItemResponse<ArchivoResponse>>
    {
        public LstItemResponse<ArchivoResponse> Present(List<ArchivoResult> input)
        {
            return new LstItemResponse<ArchivoResponse>
            {
                LstItem = ArchivoResponseMapper.ToListResponse(input),
                IsSuccess = true
            };
        }
    }
}
