namespace Usuario.Domain.Rol.Parameters
{
    public class EliminarRolParameters
    {
        public int CargoId { get; set; }
        public int UsuarioModificacion { get; set; }
        public DateTime FechaModificacion { get; set; } = DateTime.Now;
    }
}
