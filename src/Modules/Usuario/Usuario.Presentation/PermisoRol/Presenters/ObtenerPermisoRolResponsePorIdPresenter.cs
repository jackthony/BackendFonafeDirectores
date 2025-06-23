using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Usuario.Domain.User.Results;
using Usuario.Presentation.User.Responses;

namespace Usuario.Presentation.User.Mappers
{
    public class ObtenerUserResponsePorIdPresenter : IPresenterDelivery<UserResult, ItemResponse<UserResponse>>
    {
        public ItemResponse<UserResponse> Present(UserResult input)
        {
            return new ItemResponse<UserResponse>
            {
                IsSuccess = true,
                Item = UserResponseMapper.ToResponse(input),
            };
        }
    }
}
