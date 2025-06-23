using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Domain.Ubigeo.Results;
using Empresa.Presentation.Ubigeo.Mappers;
using Empresa.Presentation.Ubigeo.Responses;

namespace Empresa.Presentation.Ubigeo.Presenters
{
    public class ListUbigeoPaginadoResponsePresenter : IPresenterDelivery<PagedResult<UbigeoResult>, LstItemResponse<UbigeoResponse>>
    {
        public LstItemResponse<UbigeoResponse> Present(PagedResult<UbigeoResult> input)
        {
            return new LstItemResponse<UbigeoResponse>
            {
                LstItem = UbigeoResponseMapper.ToListResponse(input.Items),
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
