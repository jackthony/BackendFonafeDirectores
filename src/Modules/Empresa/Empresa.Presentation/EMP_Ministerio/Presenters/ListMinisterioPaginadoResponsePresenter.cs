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
            return new LstItemResponse<MinisterioResponse>
            {
                LstItem = MinisterioResponseMapper.ToListResponse(input.Items),
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
