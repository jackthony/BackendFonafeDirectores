using Shared.Kernel.Interfaces;

namespace Empresa.Application.Director.Dtos
{
    public class CrearDirectorRequest : ITrackableRequest
    {
        public int nIdEmpresa { get; set; }
        public int nTipoDocumento { get; set; }
        public string sNumeroDocumento { get; set; } = string.Empty;
        public string sNombres { get; set; } = string.Empty;
        public string sApellidos { get; set; } = string.Empty;
        public DateTime dFechaNacimiento { get; set; }
        public int nGenero { get; set; }
        public string sDistrito { get; set; } = string.Empty;
        public string sProvincia { get; set; } = string.Empty;
        public string sDepartamento { get; set; } = string.Empty;
        public string sDireccion { get; set; } = string.Empty;
        public string sTelefono { get; set; } = string.Empty;
        public string? sTelefonoSecundario { get; set; }
        public string? sTelefonoTerciario { get; set; }
        public string sCorreo { get; set; } = string.Empty;
        public string? sCorreoSecundario { get; set; }
        public string? sCorreoTerciario { get; set; }
        public int nCargo { get; set; }
        public int nTipoDirector { get; set; }
        public int nIdSector { get; set; }
        public string sProfesion { get; set; } = string.Empty;
        public decimal mDieta { get; set; }
        public int nEspecialidad { get; set; }
        public DateTime dFechaNombramiento { get; set; }
        public DateTime dFechaDesignacion { get; set; }
        public DateTime dFechaRenuncia { get; set; }
        public string sComentario { get; set; } = string.Empty;
        public int nUsuarioRegistro { get; set; }

        public int UsuarioId => nUsuarioRegistro;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_Director";
        public string CampoId => "nDirectorId";
        public int? ValorId => null;
        public string Movimiento => "Create";
    }
}
