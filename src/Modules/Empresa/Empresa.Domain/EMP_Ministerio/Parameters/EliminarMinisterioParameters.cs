/***********
 * Nombre del archivo:  EliminarMinisterioParameters.cs
 * Descripción:         Clase de parámetros utilizada para eliminar un Ministerio existente, registrando el usuario y la fecha de modificación.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para la operación de eliminación lógica o física de ministerios.
 ***********/

namespace Empresa.Domain.Ministerio.Parameters
{
    public class EliminarMinisterioParameters
    {
        public int MinisterioId { get; set; }
        public int UsuarioModificacionId { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
