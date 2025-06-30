namespace Usuario.Application.Auth.Dtos
{
    public class RecoveryAccountRequest
    {
        public required string sCorreo {  get; set; }
        public required string sNombre { get; set; }
        public required string sComentario { get; set; } = string.Empty;
    }
}
