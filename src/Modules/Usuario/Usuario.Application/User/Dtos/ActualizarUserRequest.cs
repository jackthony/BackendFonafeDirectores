namespace Usuario.Application.User.Dtos
{
    public class ActualizarUserRequest
    {
        public required int nIdUsuario { get; set; }
        public required int nUsuarioModificacion { get; set; }
        public int nIdRol { get; set; }
        public int nEstado { get; set; }
        public int nIdCargo { get; set; }
        public int nTipoPersonal { get; set; }
    }
}
