namespace Usuario.Domain.Rol.Parameters
{
    public class EliminarRolParameters
    {
        public int RolId { get; set; }
        public int UsuarioModificacionId { get; set; }
        public DateTime FechaModificacion { get; set; } = DateTime.Now;
    }
}
