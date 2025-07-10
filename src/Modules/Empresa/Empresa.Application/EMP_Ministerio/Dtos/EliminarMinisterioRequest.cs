/*****
 * Nombre de clase:     EliminarMinisterioRequest
 * Descripción:         DTO utilizado para enviar los datos necesarios al eliminar un ministerio.
 *                      Implementa ITrackableRequest para auditoría, especificando información
 *                      del módulo, tabla, campo identificador y tipo de movimiento.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para representar la solicitud de eliminación de ministerios con trazabilidad.
 *****/

using Shared.Kernel.Interfaces;

namespace Empresa.Application.Ministerio.Dtos
{
    public class EliminarMinisterioRequest : ITrackableRequest
    {
        public int nIdMinisterio { get; set; }
        public int nUsuarioModificacion { get; set; }

        public int UsuarioId => nUsuarioModificacion;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_Ministerio";
        public string CampoId => "nMinisterioId";
        public int? ValorId => nIdMinisterio;
        public string Movimiento => "Delete";
    }
}
