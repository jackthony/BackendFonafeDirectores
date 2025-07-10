/***********
 * Nombre del archivo:  ActualizarRubroParameters.cs
 * Descripción:         Clase que define los parámetros necesarios para actualizar la información de un rubro,
 *                      incluyendo su identificador, nuevo nombre y datos de auditoría de modificación.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación de clase para parámetros de actualización de rubros.
 ***********/

namespace Empresa.Domain.Rubro.Parameters
{
    public class ActualizarRubroParameters
    {
        public int RubroId { get; set; }
        public string NombreRubro { get; set; } = default!;
        public int UsuarioModificacionId { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
