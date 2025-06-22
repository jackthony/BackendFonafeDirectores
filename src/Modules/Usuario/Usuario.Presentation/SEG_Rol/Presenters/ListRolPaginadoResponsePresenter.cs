using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Domain.Rol.Results;
using Usuario.Presentation.Rol.Mappers;
using Usuario.Presentation.Rol.Responses;

namespace Usuario.Presentation.Rol.Presenters
{
    public class ListRolPaginadoResponsePresenter : IPresenterDelivery<PagedResult<RolResult>, LstItemResponse<RolResponse>>
    {
        public LstItemResponse<RolResponse> Present(PagedResult<RolResult> input)
        {
            return new LstItemResponse<RolResponse>
            {
                LstItem = RolResponseMapper.ToListResponse(input.Items),
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
