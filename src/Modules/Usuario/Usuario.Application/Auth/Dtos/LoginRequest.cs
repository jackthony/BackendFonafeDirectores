namespace Usuario.Application.Auth.Dtos
{
    public class LoginRequest
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string captchaResponse { get; set; }
    }
}
