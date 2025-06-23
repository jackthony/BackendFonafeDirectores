namespace Usuario.Presentation.User.Responses
{
    public class UserResponse
    {
        public int UsuarioId { get; set; }
        public string ApellidosYNombres { get; set; } = string.Empty;
        public string Cargo { get; set; } = string.Empty;
        public string Perfil { get; set; } = string.Empty;
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? UltimaModificacion { get; set; }
        public string Correo { get; set; } = string.Empty;
        public int indice { get; set; }
    }
}
