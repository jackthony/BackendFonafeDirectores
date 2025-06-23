namespace Usuario.Presentation.User.Responses
{
    public class UserResponse
    {
        public int nUsuarioId { get; set; }
        public string sApellidosYNombres { get; set; } = string.Empty;
        public string sCargo { get; set; } = string.Empty;
        public string sPerfil { get; set; } = string.Empty;
        public bool bEstado { get; set; }
        public DateTime dtFechaCreacion { get; set; }
        public DateTime? dtUltimaModificacion { get; set; }
        public string sCorreo { get; set; } = string.Empty;
        public int indice { get; set; }
    }
}
