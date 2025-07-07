using Shared.Kernel.Interfaces;

namespace Empresa.Application.TipoDirector.Dtos
{
    public class ActualizarTipoDirectorRequest : ITrackableRequest
    {
        public int nIdTipoDirector { get; set; }
        public string sNombreTipoDirector { get; set; } = default!;
        public int nUsuarioModificacion { get; set; }

        public int UsuarioId => nUsuarioModificacion;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_TipoDirector";
        public string CampoId => "nTipoDirectorId";
        public int? ValorId => nIdTipoDirector;
        public string Movimiento => "Update";
    }
}
