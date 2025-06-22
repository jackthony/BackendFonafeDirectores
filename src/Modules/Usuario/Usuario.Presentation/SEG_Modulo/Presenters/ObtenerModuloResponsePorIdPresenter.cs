using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Usuario.Domain.Modulo.Results;
using Usuario.Presentation.Modulo.Responses;

namespace Usuario.Presentation.Modulo.Mappers
{
    public class ObtenerModuloResponsePorIdPresenter : IPresenterDelivery<ModuloResult, ItemResponse<ModuloResponse>>
    {
        public ItemResponse<ModuloResponse> Present(ModuloResult input)
        {
            return new ItemResponse<ModuloResponse>
            {
                IsSuccess = true,
                Item = ModuloResponseMapper.ToResponse(input),
            };
        }
    }
}
