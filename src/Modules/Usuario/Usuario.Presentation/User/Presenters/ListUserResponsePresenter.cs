using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Usuario.Domain.User.Results;
using Usuario.Presentation.User.Responses;

namespace Usuario.Presentation.User.Mappers
{
    public class ListUserResponsePresenter : IPresenterDelivery<List<UserResult>, LstItemResponse<UserResponse>>
    {
        public LstItemResponse<UserResponse> Present(List<UserResult> input)
        {
            return new LstItemResponse<UserResponse>
            {
                LstItem = UserResponseMapper.ToListResponse(input),
                IsSuccess = true
            };
        }
    }
}
