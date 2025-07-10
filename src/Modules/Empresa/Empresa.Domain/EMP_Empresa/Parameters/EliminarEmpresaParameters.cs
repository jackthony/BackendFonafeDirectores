/***********
 * Nombre del archivo:  EliminarEmpresaParameters.cs
 * Descripción:         Clase que encapsula los parámetros necesarios para eliminar una empresa.
 *                      Contiene el ID de la empresa, la fecha de modificación y el usuario que realiza la acción.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para soportar operación de eliminación lógica o física de empresa.
 ***********/

namespace Empresa.Domain.Empresa.Parameters
{
    public class EliminarEmpresaParameters
    {
        public int EmpresaId { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int UsuarioModificacionId { get; set; }
    }
}
