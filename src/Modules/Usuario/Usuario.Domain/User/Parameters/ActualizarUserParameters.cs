namespace Usuario.Domain.User.Parameters
{
    public class ActualizarUserParameters
    {
        public int UsuarioId { get; set; }
        public int UsuarioModificacionId { get; set; }
        public int RolId { get; set; }
        public int Estado { get; set; }
        public int CargoId { get; set; }
        public int nTipoPersonal { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
