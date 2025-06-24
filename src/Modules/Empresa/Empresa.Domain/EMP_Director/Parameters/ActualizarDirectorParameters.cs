namespace Empresa.Domain.Director.Parameters
{
    public class ActualizarDirectorParameters
    {
        public int nDirectorId { get; set; }
        public int nEmpresaId { get; set; }
        public int? nTipoDocumentoId { get; set; } // Nullable para que no sea necesario actualizarlo siempre
        public string? sNumeroDocumento { get; set; } = string.Empty;
        public string? sNombres { get; set; } = string.Empty;
        public string? sApellidos { get; set; } = string.Empty;
        public DateTime? dtFechaNacimiento { get; set; } // Nullable para poder no actualizar la fecha de nacimiento
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
        public int? nSectorId { get; set; }
        public string? sProfesion { get; set; } = string.Empty;
        public decimal? dDieta { get; set; } // Nullable para poder no actualizar la dieta
        public int? nEspecialidadId { get; set; }
        public DateTime? dtFechaNombramiento { get; set; } // Nullable
        public DateTime? dtFechaDesignacion { get; set; } // Nullable
        public DateTime? dtFechaRenuncia { get; set; } // Nullable para el caso que no se renuncie
        public string? sComentario { get; set; } = string.Empty;
        public DateTime? dtFechaModificacion { get; set; } // Fecha de la modificación
        public int? nUsuarioModificacionId { get; set; } // El usuario que realiza la modificación
    }
}
