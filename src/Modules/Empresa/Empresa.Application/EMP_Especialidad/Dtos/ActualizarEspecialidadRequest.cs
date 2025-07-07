using Shared.Kernel.Interfaces;

namespace Empresa.Application.Especialidad.Dtos
{
    public class ActualizarEspecialidadRequest : ITrackableRequest
    {
        public int nIdEspecialidad { get; set; }
        public string sNombreEspecialidad { get; set; } = default!;
        public int nUsuarioModificacion { get; set; }

        public int UsuarioId => nUsuarioModificacion;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_Especialidad";
        public string CampoId => "nEspecialidadId";
        public int? ValorId => nIdEspecialidad;
        public string Movimiento => "Update";
    }
}
