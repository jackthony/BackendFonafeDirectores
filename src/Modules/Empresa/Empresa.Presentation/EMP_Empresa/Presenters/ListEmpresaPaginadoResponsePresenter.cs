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
            return new LstItemResponse<EmpresaResponse>
            {
                LstItem = EmpresaResponseMapper.ToListResponse(input.Items),
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
