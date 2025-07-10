/***********
 * Nombre del archivo:  EliminarCargoParameters.cs
 * Descripción:         Clase que contiene los parámetros necesarios para eliminar un cargo, incluyendo usuario y fecha de modificación.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación de la clase para parámetros de eliminación de cargo.
 ***********/

namespace Empresa.Domain.Cargo.Parameters
{
    public class EliminarCargoParameters
    {
        public int CargoId { get; set; }
        public int UsuarioModificacionId { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
