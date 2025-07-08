using Shared.Kernel.Interfaces;

namespace Usuario.Application.User.Dtos
{
    public class ActualizarUserRequest : ITrackableRequest
    {
        public required int nIdUsuario { get; set; }
        public required int nUsuarioModificacion { get; set; }
        public int nIdRol { get; set; }
        public int nEstado { get; set; }
        public int nIdCargo { get; set; }
        public int nTipoPersonal { get; set; }

        public int UsuarioId => nUsuarioModificacion;
        public string Modulo => "USUARIO";
        public string Tabla => "SEG_Usuario";
        public string CampoId => "nUsuarioId";
        public int? ValorId => nIdUsuario;
        public string Movimiento => "Update";
    }
}
