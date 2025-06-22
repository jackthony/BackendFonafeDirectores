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
            return new LstItemResponse<CargoResponse>
            {
                LstItem = CargoResponseMapper.ToListResponse(input.Items),
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
