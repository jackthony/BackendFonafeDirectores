using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Director.Results;
using Empresa.Presentation.Director.Responses;

namespace Empresa.Presentation.Director.Mappers
{
    public class ListDirectorResponsePresenter : IPresenterDelivery<List<DirectorResult>, LstItemResponse<DirectorResponse>>
    {
        public LstItemResponse<DirectorResponse> Present(List<DirectorResult> input)
        {
            return new LstItemResponse<DirectorResponse>
            {
                LstItem = DirectorResponseMapper.ToListResponse(input),
                IsSuccess = true
            };
        }
    }
}
