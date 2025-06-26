namespace Usuario.Application.Auth.Dtos
{
    public class RefreshTokenRequest
    {
        public required string sAccessToken { get; set; }
        public required string sRefreshToken { get; set; }
    }
}
