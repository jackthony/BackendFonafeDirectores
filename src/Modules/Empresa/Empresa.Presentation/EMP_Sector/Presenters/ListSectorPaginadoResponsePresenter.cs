using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Domain.Sector.Results;
using Empresa.Presentation.Sector.Mappers;
using Empresa.Presentation.Sector.Responses;

namespace Empresa.Presentation.Sector.Presenters
{
    public class ListSectorPaginadoResponsePresenter : IPresenterDelivery<PagedResult<SectorResult>, LstItemResponse<SectorResponse>>
    {
        public LstItemResponse<SectorResponse> Present(PagedResult<SectorResult> input)
        {
            return new LstItemResponse<SectorResponse>
            {
                LstItem = SectorResponseMapper.ToListResponse(input.Items),
                Pagination = new Pagination
                {
                    PageIndex = input.Page,
                    PageSize = input.PageSize,
                    TotalRows = input.TotalItems
                },
                IsSuccess = true
            };
        }
    }
}
