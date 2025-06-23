using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Domain.User.Results;
using Usuario.Presentation.User.Mappers;
using Usuario.Presentation.User.Responses;

namespace Usuario.Presentation.User.Presenters
{
    public class ListUserPaginadoResponsePresenter : IPresenterDelivery<PagedResult<UserResult>, LstItemResponse<UserResponse>>
    {
        public LstItemResponse<UserResponse> Present(PagedResult<UserResult> input)
        {
            return new LstItemResponse<UserResponse>
            {
                LstItem = UserResponseMapper.ToListResponse(input.Items),
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
