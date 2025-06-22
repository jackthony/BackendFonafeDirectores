using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Director.Results;
using Empresa.Presentation.Director.Responses;

namespace Empresa.Presentation.Director.Mappers
{
    public class ObtenerDirectorResponsePorIdPresenter : IPresenterDelivery<DirectorResult, ItemResponse<DirectorResponse>>
    {
        public ItemResponse<DirectorResponse> Present(DirectorResult input)
        {
            return new ItemResponse<DirectorResponse>
            {
                IsSuccess = true,
                Item = DirectorResponseMapper.ToResponse(input),
            };
        }
    }
}
