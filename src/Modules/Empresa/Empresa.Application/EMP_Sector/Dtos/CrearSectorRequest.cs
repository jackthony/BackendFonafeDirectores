using Shared.Kernel.Interfaces;

namespace Empresa.Application.Sector.Dtos
{
    public class CrearSectorRequest : ITrackableRequest
    {
        public string sNombreSector { get; set; } = default!;
        public int nUsuarioRegistro { get; set; }

        public int UsuarioId => nUsuarioRegistro;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_Sector";
        public string CampoId => "nSectorId";
        public int? ValorId => null;
        public string Movimiento => "Create";
    }
}
