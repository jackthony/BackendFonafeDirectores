using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Archivo.Domain.Archivo.Results;
using Archivo.Presentation.Archivo.Responses;

namespace Archivo.Presentation.Archivo.Mappers
{
    public class ObtenerArchivoResponsePorIdPresenter : IPresenterDelivery<ArchivoResult, ItemResponse<ArchivoResponse>>
    {
        public ItemResponse<ArchivoResponse> Present(ArchivoResult input)
        {
            return new ItemResponse<ArchivoResponse>
            {
                IsSuccess = true,
                //Item = ArchivoResponseMapper.ToResponse(input),
            };
        }
    }
}
