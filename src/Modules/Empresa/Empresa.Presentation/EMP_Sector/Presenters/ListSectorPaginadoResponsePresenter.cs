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
            int startIndex = (input.Page - 1) * input.PageSize;

            var lista = SectorResponseMapper.ToListResponse(input.Items);
            var listaItems = lista.ToList();
            for (int i = 0; i < listaItems.Count; i++)
            {
                listaItems[i].indice = startIndex + i + 1;
            }
            return new LstItemResponse<SectorResponse>
            {
                LstItem = listaItems,
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
