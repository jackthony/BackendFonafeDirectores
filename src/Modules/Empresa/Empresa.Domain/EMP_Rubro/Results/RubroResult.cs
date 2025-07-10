/***********
 * Nombre del archivo:  RubroResult.cs
 * Descripción:         Clase que representa el resultado devuelto al consultar la información de un rubro,
 *                      incluyendo su ID, nombre, estado, fechas y trazabilidad de registro/modificación.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial del DTO de resultado para rubros.
 ***********/

namespace Empresa.Domain.Rubro.Results
{
    public class RubroResult
    {
        public int RubroId { get; set; }
        public string NombreRubro { get; set; } = default!;
        public bool IsActivo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? UsuarioModificacionId { get; set; }
    }
}
