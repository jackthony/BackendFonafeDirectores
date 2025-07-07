using Shared.Kernel.Interfaces;

namespace Empresa.Application.Ministerio.Dtos
{
    public class EliminarMinisterioRequest : ITrackableRequest
    {
        public int nIdMinisterio { get; set; }
        public int nUsuarioModificacion { get; set; }

        public int UsuarioId => nUsuarioModificacion;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_Ministerio";
        public string CampoId => "nMinisterioId";
        public int? ValorId => nIdMinisterio;
        public string Movimiento => "Delete";
    }
}
