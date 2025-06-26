using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Empresa.Domain.TipoDirector.Results;
using Empresa.Presentation.TipoDirector.Responses;

namespace Empresa.Presentation.TipoDirector.Mappers
{
    public class ListTipoDirectorResponsePresenter : IPresenterDelivery<List<TipoDirectorResult>, LstItemResponse<TipoDirectorResponse>>
    {
        public LstItemResponse<TipoDirectorResponse> Present(List<TipoDirectorResult> input)
        {
            return new LstItemResponse<TipoDirectorResponse>
            {
                LstItem = TipoDirectorResponseMapper.ToListResponse(input),
                IsSuccess = true
            };
        }
    }
}
