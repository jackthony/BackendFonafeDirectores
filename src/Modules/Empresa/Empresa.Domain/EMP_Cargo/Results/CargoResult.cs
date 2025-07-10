/***********
 * Nombre del archivo:  CargoResult.cs
 * Descripción:         Clase que representa el resultado con los datos de un cargo.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación de la clase CargoResult con sus propiedades.
 ***********/

namespace Empresa.Domain.Cargo.Results
{
    public class CargoResult
    {
        public int CargoId { get; set; }
        public string NombreCargo { get; set; } = default!;
        public bool IsActivo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? UsuarioModificacionId { get; set; }
    }
}
