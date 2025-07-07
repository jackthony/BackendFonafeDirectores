using Shared.Kernel.Interfaces;

namespace Empresa.Application.Rubro.Dtos
{
    public class EliminarRubroRequest : ITrackableRequest
    {
        public int nIdRubro { get; set; }
        public int nUsuarioModificacion { get; set; }

        public int UsuarioId => nUsuarioModificacion;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_Rubro";
        public string CampoId => "nRubroId";
        public int? ValorId => nIdRubro;
        public string Movimiento => "Delete";
    }
}
