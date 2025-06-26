using System.Security.Claims;

namespace Usuario.Application.Auth.Services
{
    public interface ITokenService
    {
        public string GenerateAccessToken(int userId, string email, IList<string> roles);
        public string GenerateRefreshToken();
        public ClaimsPrincipal? ValidateAccessToken(string token);
        public int? GetUserIdFromExpiredToken(string token);
    }
}
