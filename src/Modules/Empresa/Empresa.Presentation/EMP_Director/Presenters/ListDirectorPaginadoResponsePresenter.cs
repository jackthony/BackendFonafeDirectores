using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Domain.Director.Results;
using Empresa.Presentation.Director.Mappers;
using Empresa.Presentation.Director.Responses;

namespace Empresa.Presentation.Director.Presenters
{
    public class ListDirectorPaginadoResponsePresenter : IPresenterDelivery<PagedResult<DirectorResult>, LstItemResponse<DirectorResponse>>
    {
        public LstItemResponse<DirectorResponse> Present(PagedResult<DirectorResult> input)
        {
            int startIndex = (input.Page - 1) * input.PageSize;

            var lista = DirectorResponseMapper.ToListResponse(input.Items);
            var listaItems = lista.ToList();
            for (int i = 0; i < listaItems.Count; i++)
            {
                listaItems[i].indice = startIndex + i + 1;
            }
            return new LstItemResponse<DirectorResponse>
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
