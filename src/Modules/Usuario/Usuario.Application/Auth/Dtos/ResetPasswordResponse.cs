namespace Usuario.Application.Auth.Dtos
{
    public class ResetPasswordResponse
    {
        public bool Success { get; set; }  // Indica si la operación fue exitosa (true) o fallida (false)
        public string Message { get; set; } = default!;  // Mensaje que explica el resultado (éxito o error)
    }
}
