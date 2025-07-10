/***********
 * Nombre del archivo:  EspecialidadResult.cs
 * Descripción:         Clase DTO que representa los datos de una especialidad obtenidos desde la base de datos,
 *                      incluyendo información de auditoría y estado.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para representar el resultado de una consulta de especialidad.
 ***********/

namespace Empresa.Domain.Especialidad.Results
{
    public class EspecialidadResult
    {
        public int EspecialidadId { get; set; }
        public string NombreEspecialidad { get; set; } = default!;
        public bool IsActivo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? UsuarioModificacionId { get; set; }
    }
}
