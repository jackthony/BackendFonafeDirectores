using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Empresa.Domain.TipoDirector.Results;
using Empresa.Presentation.TipoDirector.Responses;

namespace Empresa.Presentation.TipoDirector.Mappers
{
    public class ObtenerTipoDirectorResponsePorIdPresenter : IPresenterDelivery<TipoDirectorResult, ItemResponse<TipoDirectorResponse>>
    {
        public ItemResponse<TipoDirectorResponse> Present(TipoDirectorResult input)
        {
            return new ItemResponse<TipoDirectorResponse>
            {
                IsSuccess = true,
                Item = TipoDirectorResponseMapper.ToResponse(input),
            };
        }
    }
}
