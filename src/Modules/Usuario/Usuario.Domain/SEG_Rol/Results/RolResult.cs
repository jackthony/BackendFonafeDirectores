namespace Usuario.Domain.Rol.Results
{
    public class RolResult
    {
        public int RolId { get; set; }
        public string NombreRol { get; set; } =  string.Empty;
        public bool Activo { get; set; }
        public DateTime FechaRegistro  { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? UsuarioModificacionId { get; set; }
    }
}
