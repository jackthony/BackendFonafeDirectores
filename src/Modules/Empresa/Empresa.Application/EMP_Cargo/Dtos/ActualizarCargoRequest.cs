using Shared.Kernel.Interfaces;

namespace Empresa.Application.Cargo.Dtos
{
    public class ActualizarCargoRequest : ITrackableRequest
    {
        public int nIdCargo { get; set; }
        public string sNombreCargo { get; set; } = default!;
        public int nUsuarioModificacion { get; set; }

        public int UsuarioId => nUsuarioModificacion;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_Cargo";
        public string CampoId => "nCargoId";
        public int? ValorId => nIdCargo;
        public string Movimiento => "Update";
    }
}
