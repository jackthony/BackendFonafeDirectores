using Usuario.Domain.User.Results;
using Usuario.Presentation.User.Responses;

namespace Usuario.Presentation.User.Mappers
{
    public static class UserResponseMapper
    {
        public static UserResponse ToResponse(UserResult dto) => new()
        {
        };

        public static IEnumerable<UserResponse> ToListResponse(IEnumerable<UserResult> items)
            => items.Select(ToResponse);
    }
}
