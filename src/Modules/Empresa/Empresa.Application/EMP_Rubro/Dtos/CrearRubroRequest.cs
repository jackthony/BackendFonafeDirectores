using Shared.Kernel.Interfaces;

namespace Empresa.Application.Rubro.Dtos
{
    public class CrearRubroRequest : ITrackableRequest
    {
        public string sNombreRubro { get; set; } = default!;
        public int nUsuarioRegistro { get; set; }

        public int UsuarioId => nUsuarioRegistro;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_Rubro";
        public string CampoId => "nRubroId";
        public int? ValorId => null;
        public string Movimiento => "Create";
    }
}
