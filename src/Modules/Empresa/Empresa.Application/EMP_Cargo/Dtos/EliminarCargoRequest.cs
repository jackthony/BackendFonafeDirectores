using Shared.Kernel.Interfaces;

namespace Empresa.Application.Cargo.Dtos
{
    public class EliminarCargoRequest : ITrackableRequest
    {
        public int nIdCargo { get; set; }
        public int nUsuarioModificacion { get; set; }

        public int UsuarioId => nUsuarioModificacion;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_Cargo";
        public string CampoId => "nCargoId";
        public int? ValorId => nIdCargo;
        public string Movimiento => "Delete";
    }
}
