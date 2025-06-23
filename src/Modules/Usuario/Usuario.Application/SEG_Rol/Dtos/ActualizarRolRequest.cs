namespace Usuario.Application.Rol.Dtos
{
    public class ActualizarRolRequest
    {
        public int nIdRol { get; set; }
        public int nUsuarioModificacion { get; set; }
        public DateTime dtFechaModificacion { get; set; } = DateTime.Now;
        public string sNombreRol { get; set; } = string.Empty;
    }
}
