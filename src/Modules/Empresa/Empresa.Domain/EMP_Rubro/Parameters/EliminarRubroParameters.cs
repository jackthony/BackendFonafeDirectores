/***********
 * Nombre del archivo:  EliminarRubroParameters.cs
 * Descripción:         Clase que define los parámetros necesarios para eliminar lógicamente un rubro,
 *                      incluyendo el identificador del rubro y los datos de auditoría de modificación.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de parámetros para eliminación de rubros.
 ***********/

namespace Empresa.Domain.Rubro.Parameters
{
    public class EliminarRubroParameters
    {
        public int RubroId { get; set; }
        public int UsuarioModificacionId { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
