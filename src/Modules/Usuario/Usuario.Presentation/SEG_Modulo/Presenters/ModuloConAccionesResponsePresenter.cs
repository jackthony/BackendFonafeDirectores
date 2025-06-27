using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Usuario.Domain.Modulo.Results;
using Usuario.Presentation.Modulo.Mappers;
using Usuario.Presentation.Modulo.Responses;

namespace Usuario.Presentation.Modulo.Presenters
{
    public class ModuloConAccionesResponsePresenter : IPresenterDelivery<List<ModuloConAccionesResult>, LstItemResponse<ModuloConAccionesResponse>>
    {
        public LstItemResponse<ModuloConAccionesResponse> Present(List<ModuloConAccionesResult> input)
        {
            return new LstItemResponse<ModuloConAccionesResponse>
            {
                LstItem = ModuloConAccionesResponseMapper.ToListResponse(input),
                IsSuccess = true
            };
        }
    }
}
