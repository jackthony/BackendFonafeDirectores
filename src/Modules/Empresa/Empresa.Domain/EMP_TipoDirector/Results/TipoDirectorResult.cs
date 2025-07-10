/***********
 * Nombre del archivo:  TipoDirectorResult.cs
 * Descripción:         DTO que representa los datos de un tipo de director, incluyendo su identificador,
 *                      nombre, estado, fechas y usuarios de registro y modificación. Utilizado como resultado en consultas.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial del DTO TipoDirectorResult.
 ***********/

namespace Empresa.Domain.TipoDirector.Results
{
    public class TipoDirectorResult
    {
        public int TipoDirectorId { get; set; }
        public string NombreTipoDirector { get; set; } = default!;
        public bool IsActivo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? UsuarioModificacionId { get; set; }
    }
}
