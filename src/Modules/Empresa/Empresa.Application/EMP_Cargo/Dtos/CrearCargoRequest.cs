using Shared.Kernel.Interfaces;

namespace Empresa.Application.Cargo.Dtos
{
    public class CrearCargoRequest : ITrackableRequest
    {
        public string sNombreCargo { get; set; } = default!;
        public int nUsuarioRegistro { get; set; }

        public int UsuarioId => nUsuarioRegistro;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_Cargo";
        public string CampoId => "nCargoId";
        public int? ValorId => null;
        public string Movimiento => "Create";
    }
}
