namespace Usuario.Application.Auth.Dtos
{
    public class AdminResetPasswordRequest
    {
        public required int UsuarioId { get; set; }   // ID del usuario cuya contraseña será restablecida
        public required string NewPassword { get; set; }  // Nueva contraseña
        public required string Token { get; set; }     // Token del administrador (usado para verificar permisos)
    }
}
