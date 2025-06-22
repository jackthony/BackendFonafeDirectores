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
            return new LstItemResponse<RubroResponse>
            {
                LstItem = RubroResponseMapper.ToListResponse(input.Items),
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
