/***********
 * Nombre del archivo:  ActualizarDirectorParameters.cs
 * Descripción:         Clase que contiene los parámetros para actualizar la información de un director,
 *                      incluyendo datos personales, contacto, cargo, fechas importantes, y datos de auditoría.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación de la clase para parámetros de actualización de director.
 ***********/

namespace Empresa.Domain.Director.Parameters
{
    public class ActualizarDirectorParameters
    {
        public int nDirectorId { get; set; }
        public int nEmpresaId { get; set; }
        public int? nDepartamentoId { get; set; }
        public int? nProvinciaId { get; set; }
        public int? nDistritoId { get; set; }
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
