using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Domain.Empresa.Results;
using Empresa.Presentation.Empresa.Mappers;
using Empresa.Presentation.Empresa.Responses;

namespace Empresa.Presentation.Empresa.Presenters
{
    public class ListEmpresaPaginadoResponsePresenter : IPresenterDelivery<PagedResult<EmpresaResult>, LstItemResponse<EmpresaResponse>>
    {
        public LstItemResponse<EmpresaResponse> Present(PagedResult<EmpresaResult> input)
        {
            int startIndex = (input.Page - 1) * input.PageSize;

            var lista = EmpresaResponseMapper.ToListResponse(input.Items);
            var listaItems = lista.ToList();
            for (int i = 0; i < listaItems.Count; i++)
            {
                listaItems[i].indice = startIndex + i + 1;
            }
            return new LstItemResponse<EmpresaResponse>
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
