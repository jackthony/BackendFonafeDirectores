namespace Empresa.Application.Director.Dtos
{
    public class ActualizarDirectorRequest
    {
        public int nDirectorId { get; set; }
        public int nEmpresaId { get; set; }
        public int? nTipoDocumentoId { get; set; }
        public string? sNumeroDocumento { get; set; } = string.Empty;
        public string? sNombres { get; set; } = string.Empty;
        public string? sApellidos { get; set; } = string.Empty;
        public DateTime? dtFechaNacimiento { get; set; }
        public int? nGeneroId { get; set; }
        public int? nDistritoId { get; set; }
        public int? nProvinciaId { get; set; }
        public int? nDepartamentoId { get; set; }
        public string? sDireccion { get; set; } = string.Empty;
        public string? sTelefono { get; set; } = string.Empty;
        public string? sTelefonoSecundario { get; set; } = string.Empty;
        public string? sTelefonoTerciario { get; set; } = string.Empty;
        public string? sCorreo { get; set; } = string.Empty;
        public string? sCorreoSecundario { get; set; } = string.Empty;
        public string? sCorreoTerciario { get; set; } = string.Empty;
        public int? nCargoId { get; set; }
        public int? nTipoDirectorId { get; set; }
        public int? nIdSector { get; set; }
        public string? sProfesion { get; set; } = string.Empty;
        public decimal? dDieta { get; set; }
        public int? nEspecialidadId { get; set; }
        public DateTime? dtFechaNombramiento { get; set; }
        public DateTime? dtFechaDesignacion { get; set; }
        public DateTime? dtFechaRenuncia { get; set; }
        public string? sComentario { get; set; } = string.Empty;
        public DateTime? dtFechaModificacion { get; set; }
        public int? nUsuarioModificacionId { get; set; }
    }
}
