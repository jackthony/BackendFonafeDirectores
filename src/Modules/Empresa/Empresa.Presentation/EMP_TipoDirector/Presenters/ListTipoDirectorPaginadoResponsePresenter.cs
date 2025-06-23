using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Domain.TipoDirector.Results;
using Empresa.Presentation.TipoDirector.Mappers;
using Empresa.Presentation.TipoDirector.Responses;

namespace Empresa.Presentation.TipoDirector.Presenters
{
    public class ListTipoDirectorPaginadoResponsePresenter : IPresenterDelivery<PagedResult<TipoDirectorResult>, LstItemResponse<TipoDirectorResponse>>
    {
        public LstItemResponse<TipoDirectorResponse> Present(PagedResult<TipoDirectorResult> input)
        {
            int startIndex = (input.Page - 1) * input.PageSize;

            var lista = TipoDirectorResponseMapper.ToListResponse(input.Items);
            var listaItems = lista.ToList();
            for (int i = 0; i < listaItems.Count; i++)
            {
                listaItems[i].indice = startIndex + i + 1;
            }
            return new LstItemResponse<TipoDirectorResponse>
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
