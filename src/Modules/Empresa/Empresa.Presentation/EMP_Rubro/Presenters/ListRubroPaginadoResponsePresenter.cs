using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Domain.Rubro.Results;
using Empresa.Presentation.Rubro.Mappers;
using Empresa.Presentation.Rubro.Responses;

namespace Empresa.Presentation.Rubro.Presenters
{
    public class ListRubroPaginadoResponsePresenter : IPresenterDelivery<PagedResult<RubroResult>, LstItemResponse<RubroResponse>>
    {
        public LstItemResponse<RubroResponse> Present(PagedResult<RubroResult> input)
        {
            int startIndex = (input.Page - 1) * input.PageSize;

            var lista = RubroResponseMapper.ToListResponse(input.Items);
            var listaItems = lista.ToList();
            for (int i = 0; i < listaItems.Count; i++)
            {
                listaItems[i].indice = startIndex + i + 1;
            }
            return new LstItemResponse<RubroResponse>
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
