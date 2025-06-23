namespace Usuario.Presentation.Rol.Responses
{
    public class RolResponse
    {
        public int nRolId { get; set; }
        public string sNombreRol { get; set; } = string.Empty;
        public bool bActivo { get; set; }
        public DateTime dtFechaRegistro { get; set; }
        public int nUsuarioRegistroId { get; set; }
        public DateTime? dtFechaModificacion { get; set; }
        public int? nUsuarioModificacionId { get; set; }
        public int indice { get; set; }
    }
}
