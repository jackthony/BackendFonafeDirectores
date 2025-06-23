namespace Usuario.Domain.User.Results
{
    public class UserResult
    {
        public int UsuarioId { get; set; }
        public string Username { get; set; } = string.Empty;
        public string CorreoElectronico { get; set; } = string.Empty;
        public string ApellidoPaterno { get; set; } = string.Empty;
        public string ApellidoMaterno { get; set; } = string.Empty;
        public string Nombres { get; set; } = string.Empty;
        public int Estado { get; set; }
        public bool IsActivo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? UsuarioModificacionId { get; set; }
    }
}
