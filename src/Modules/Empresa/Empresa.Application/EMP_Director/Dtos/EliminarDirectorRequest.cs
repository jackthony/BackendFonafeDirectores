using Shared.Kernel.Interfaces;

namespace Empresa.Application.Director.Dtos
{
    public class EliminarDirectorRequest : ITrackableRequest
    {
        public int nDirectorId { get; set; }
        public int nUsuarioModificacionId { get; set; }
        public DateTime dtFechaModificacion { get; set; }

        public int UsuarioId => nUsuarioModificacionId;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_Director";
        public string CampoId => "nDirectorId";
        public int? ValorId => nDirectorId;
        public string Movimiento => "Delete";
    }
}
