using Shared.Kernel.Interfaces;

namespace Empresa.Application.TipoDirector.Dtos
{
    public class CrearTipoDirectorRequest : ITrackableRequest
    {
        public string sNombreTipoDirector { get; set; } = default!;
        public int nUsuarioRegistro { get; set; }

        public int UsuarioId => nUsuarioRegistro;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_TipoDirector";
        public string CampoId => "nTipoDirectorId";
        public int? ValorId => 0;
        public string Movimiento => "Create";
    }
}
