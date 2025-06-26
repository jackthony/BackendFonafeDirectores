namespace Usuario.Domain.User.Results
{
    public class UserResult
    {
        public int IdUsuario { get; set; }
        public string ApellidoPaterno { get; set; } = string.Empty;
        public string ApellidoMaterno { get; set; } = string.Empty;
        public string Nombres { get; set; } = string.Empty;
        public int IdCargo { get; set; }
        public int nTipoPersonal { get; set; }
        public int IdRol { get; set; }
        public string CorreoElectronico { get; set; } = string.Empty;
        public int Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistro { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public string? CargoDescripcion { get; set; }
        public string? PerfilDescripcion { get; set; }
        public string? EstadoDescripcion { get; set; }
        public string? tipoPersonalDescripcion { get; set; }
    }
}
