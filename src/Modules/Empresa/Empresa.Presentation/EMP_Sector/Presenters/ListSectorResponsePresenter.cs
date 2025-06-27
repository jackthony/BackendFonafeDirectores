using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Sector.Results;
using Empresa.Presentation.Sector.Responses;

namespace Empresa.Presentation.Sector.Mappers
{
    public class ListSectorResponsePresenter : IPresenterDelivery<List<SectorResult>, LstItemResponse<SectorResponse>>
    {
        public LstItemResponse<SectorResponse> Present(List<SectorResult> input)
        {
            return new LstItemResponse<SectorResponse>
            {
                LstItem = SectorResponseMapper.ToListResponse(input),
                IsSuccess = true
            };
        }
    }
}
