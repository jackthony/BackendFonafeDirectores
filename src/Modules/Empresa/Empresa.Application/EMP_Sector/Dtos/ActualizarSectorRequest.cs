using Shared.Kernel.Interfaces;

namespace Empresa.Application.Sector.Dtos
{
    public class ActualizarSectorRequest : ITrackableRequest
    {
        public int nIdSector { get; set; }
        public string sNombreSector { get; set; } = default!;
        public int nUsuarioModificacion { get; set; }

        public int UsuarioId => nUsuarioModificacion;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_Sector";
        public string CampoId => "nSectorId";
        public int? ValorId => nIdSector;
        public string Movimiento => "Update";
    }
}
