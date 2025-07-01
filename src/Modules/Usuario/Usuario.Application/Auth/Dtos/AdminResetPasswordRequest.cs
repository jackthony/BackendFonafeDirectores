namespace Usuario.Application.Auth.Dtos
{
    public class AdminResetPasswordRequest
    {
        public required int UsuarioId { get; set; }      // ID del usuario cuya contraseña será restablecida
        public required int UsuarioModificaId { get; set; }  // ID del usuario que cambia la clave
        public required string NewPassword { get; set; }  // Nueva contraseña (en texto plano)
        public required string Token { get; set; }        // Token del administrador (usado para verificar permisos)
    }
}
