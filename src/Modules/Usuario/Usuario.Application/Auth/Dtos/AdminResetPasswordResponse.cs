namespace Usuario.Application.Auth.Dtos
{
    public class AdminResetPasswordResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; } = default!;
    }
}
