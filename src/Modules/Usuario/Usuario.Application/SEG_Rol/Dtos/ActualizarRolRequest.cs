namespace Usuario.Application.Rol.Dtos
{
    public class ActualizarRolRequest
    {
        public int nRolId { get; set; }
        public int nIdUsuarioModificacion { get; set; }
        public DateTime dtFechaModificacion { get; set; } = DateTime.Now;
        public string sNombreRol { get; set; } = string.Empty;
    }
}
