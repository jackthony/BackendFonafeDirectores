using Shared.Kernel.Interfaces;

namespace Empresa.Application.Especialidad.Dtos
{
    public class CrearEspecialidadRequest : ITrackableRequest
    {
        public string sNombreEspecialidad { get; set; } = default!;
        public int nUsuarioRegistro { get; set; }

        public int UsuarioId => nUsuarioRegistro;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_Especialidad";
        public string CampoId => "nEspecialidadId";
        public int? ValorId => null;
        public string Movimiento => "Create";
    }
}
