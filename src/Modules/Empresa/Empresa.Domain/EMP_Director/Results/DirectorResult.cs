namespace Empresa.Domain.Director.Results
{
    public class DirectorResult
    {
        public int DirectorId { get; set; }

        public int NombreEmpresa { get; set; }

        public int TipoDocumento { get; set; }
        public int NumeroDocumento { get; set; }

        public string Nombres { get; set; } = string.Empty;

        public string Apellidos { get; set; } = string.Empty;

        public DateTime? FechaNacimiento { get; set; }

        public string Genero { get; set; } = string.Empty;

        public string DistritoNombre { get; set; } = string.Empty;

        public string ProvinciaNombre { get; set; } = string.Empty;

        public string DepartamentoNombre { get; set; } = string.Empty;

        public string? Direccion { get; set; } = string.Empty;

        public string? Telefono { get; set; } = string.Empty;

        public string? TelefonoSecunadario { get; set; } = string.Empty;

        public string? TelefonoTerciario { get; set; } = string.Empty;

        public string? Correo { get; set; } = string.Empty;

        public string? CorreoSecundario { get; set; } = string.Empty;

        public string? CorreoTerciario { get; set; } = string.Empty;

        public string CargoNombre { get; set; } = string.Empty;

        public string TipoDirector { get; set; } = string.Empty;

        public string SectorNombre { get; set; } = string.Empty;

        public string? Profesion { get; set; } = string.Empty;

        public decimal? Dieta { get; set; }

        public string Especialidad { get; set; } = string.Empty;

        public DateTime? FechaNombramiento { get; set; }

        public DateTime? FechaDesignacion { get; set; }

        public DateTime? FechaRenuncia { get; set; }

        public string? Comentario { get; set; } = string.Empty;

        public DateTime FechaRegistro { get; set; }

        public string UsuarioRegistroId { get; set; } = string.Empty;

        public DateTime? FechaModificacion { get; set; }

        public string UsuarioModificacionId { get; set; } = string.Empty;
    }
}
