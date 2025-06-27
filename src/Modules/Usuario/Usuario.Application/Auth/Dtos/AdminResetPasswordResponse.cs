namespace Usuario.Application.Auth.Dtos
{
    public class AdminResetPasswordResponse
    {
        public bool isSuccess { get; set; }
        public string Message { get; set; } = default!;
    }
}
