using Shared.Kernel.Interfaces;

namespace Empresa.Application.Empresa.Dtos
{
    public class EliminarEmpresaRequest : ITrackableRequest
    {
        public int nIdEmpresa { get; set; }
        public int nUsuarioModificacion { get; set; }

        public int UsuarioId => nUsuarioModificacion;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_Empresa";
        public string CampoId => "nEmpresaId";
        public int? ValorId => nIdEmpresa;
        public string Movimiento => "Delete";
    }
}
