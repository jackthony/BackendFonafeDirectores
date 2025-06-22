using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Sector.Results;
using Empresa.Presentation.Sector.Responses;

namespace Empresa.Presentation.Sector.Mappers
{
    public class ObtenerSectorResponsePorIdPresenter : IPresenterDelivery<SectorResult, ItemResponse<SectorResponse>>
    {
        public ItemResponse<SectorResponse> Present(SectorResult input)
        {
            return new ItemResponse<SectorResponse>
            {
                IsSuccess = true,
                Item = SectorResponseMapper.ToResponse(input),
            };
        }
    }
}
