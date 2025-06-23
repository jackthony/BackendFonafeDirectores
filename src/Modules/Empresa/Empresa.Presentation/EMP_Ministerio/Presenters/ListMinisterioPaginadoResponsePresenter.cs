using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Domain.Ministerio.Results;
using Empresa.Presentation.Ministerio.Mappers;
using Empresa.Presentation.Ministerio.Responses;

namespace Empresa.Presentation.Ministerio.Presenters
{
    public class ListMinisterioPaginadoResponsePresenter : IPresenterDelivery<PagedResult<MinisterioResult>, LstItemResponse<MinisterioResponse>>
    {
        public LstItemResponse<MinisterioResponse> Present(PagedResult<MinisterioResult> input)
        {
            int startIndex = (input.Page - 1) * input.PageSize;

            var lista = MinisterioResponseMapper.ToListResponse(input.Items);
            var listaItems = lista.ToList();
            for (int i = 0; i < listaItems.Count; i++)
            {
                listaItems[i].indice = startIndex + i + 1;
            }
            return new LstItemResponse<MinisterioResponse>
            {
                LstItem = lista,
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
