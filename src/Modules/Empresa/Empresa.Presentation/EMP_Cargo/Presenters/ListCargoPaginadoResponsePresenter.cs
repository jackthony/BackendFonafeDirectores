using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Domain.Cargo.Results;
using Empresa.Presentation.Cargo.Mappers;
using Empresa.Presentation.Cargo.Responses;

namespace Empresa.Presentation.Cargo.Presenters
{
    public class ListCargoPaginadoResponsePresenter : IPresenterDelivery<PagedResult<CargoResult>, LstItemResponse<CargoResponse>>
    {
        public LstItemResponse<CargoResponse> Present(PagedResult<CargoResult> input)
        {
            int startIndex = (input.Page - 1) * input.PageSize;

            var lista = CargoResponseMapper.ToListResponse(input.Items);
            var listaItems = lista.ToList();
            for (int i = 0; i < listaItems.Count; i++)
            {
                listaItems[i].indice = startIndex + i + 1;
            }
            return new LstItemResponse<CargoResponse>
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
