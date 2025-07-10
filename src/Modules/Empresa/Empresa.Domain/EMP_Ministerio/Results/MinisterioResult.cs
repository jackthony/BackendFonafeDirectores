/***********
 * Nombre del archivo:  MinisterioResult.cs
 * Descripción:         Clase DTO que representa el resultado de una consulta de ministerio, incluyendo
 *                      su identificador, nombre, estado, y datos de auditoría (registro y modificación).
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación de clase de resultado para entidad Ministerio.
 ***********/

namespace Empresa.Domain.Ministerio.Results
{
    public class MinisterioResult
    {
        public int MinisterioId { get; set; }
        public string NombreMinisterio { get; set; } = default!;
        public bool IsActivo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? UsuarioModificacionId { get; set; }
    }
}
