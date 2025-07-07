using Shared.Kernel.Interfaces;

namespace Empresa.Application.Ministerio.Dtos
{
    public class CrearMinisterioRequest : ITrackableRequest
    {
        public string sNombreMinisterio { get; set; } = default!;
        public int nUsuarioRegistroId { get; set; }

        public int UsuarioId => nUsuarioRegistroId;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_Ministerio";
        public string CampoId => "nMinisterioId";
        public int? ValorId => null;
        public string Movimiento => "Create";
    }
}
