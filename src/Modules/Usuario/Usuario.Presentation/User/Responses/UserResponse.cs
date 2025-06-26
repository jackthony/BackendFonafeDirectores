namespace Usuario.Presentation.User.Responses
{
    public class UserResponse
    {
        public int nIdUsuario { get; set; }
        public string sApellidoPaterno { get; set; } = string.Empty;
        public string sApellidoMaterno { get; set; } = string.Empty;
        public string sNombres { get; set; } = string.Empty;
        public int nIdCargo { get; set; }
        public int nIdRol { get; set; }
        public string sCorreoElectronico { get; set; } = string.Empty;
        public int nEstado { get; set; }
        public DateTime dtFechaRegistro { get; set; }
        public int nUsuarioRegistro { get; set; }
        public DateTime? dtFechaModificacion { get; set; }
        public int? nUsuarioModificacion { get; set; }
        public string? sCargoDescripcion { get; set; }
        public string? sPerfilDescripcion { get; set; }
        public string? sEstadoDescripcion { get; set; }
        public string? sApellidosYNombres { get; set; }
        public int indice { get; set; }
    }
}
