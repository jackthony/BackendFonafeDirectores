namespace Usuario.Presentation.User.Responses
{
    public class UserResponse
    {
        public int nUsuarioId { get; set; }
        public string sUsername { get; set; } = string.Empty;
        public string sCorreoElectronico { get; set; } = string.Empty;
        public string sApellidoPaterno { get; set; } = string.Empty;
        public string sApellidoMaterno { get; set; } = string.Empty;
        public string sNombres { get; set; } = string.Empty;
        public int nEstado { get; set; }
        public bool bIsActivo { get; set; }
        public DateTime dtFechaRegistro { get; set; }
        public int nUsuarioRegistroId { get; set; }
        public DateTime? dtFechaModificacion { get; set; }
        public int? nUsuarioModificacionId { get; set; }
        public int indice { get; set; }
    }
}
