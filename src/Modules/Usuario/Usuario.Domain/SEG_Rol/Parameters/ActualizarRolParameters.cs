namespace Usuario.Domain.Rol.Parameters
{
    public class ActualizarRolParameters
    {
        public int RolId { get; set; }
        public int UsuarioModificacionId {  get; set; }
        public DateTime FechaModificacion { get; set; } = DateTime.Now;
        public string NombreRol { get; set; } = string.Empty;
    }
}
