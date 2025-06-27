using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Usuario.Domain.Modulo.Results;
using Usuario.Presentation.Modulo.Responses;

namespace Usuario.Presentation.Modulo.Mappers
{
    public class ListModuloResponsePresenter : IPresenterDelivery<List<ModuloResult>, LstItemResponse<ModuloResponse>>
    {
        public LstItemResponse<ModuloResponse> Present(List<ModuloResult> input)
        {
            return new LstItemResponse<ModuloResponse>
            {
                LstItem = ModuloResponseMapper.ToListResponse(input),
                IsSuccess = true
            };
        }
    }
}
