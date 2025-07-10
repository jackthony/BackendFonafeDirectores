/*****
 * Nombre de clase:     ActualizarMinisterioRequest
 * Descripción:         DTO utilizado para enviar los datos necesarios para actualizar un ministerio existente.
 *                      Implementa ITrackableRequest para permitir la trazabilidad de la operación,
 *                      especificando el módulo, la tabla, el identificador y el tipo de movimiento.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para representar la solicitud de actualización de ministerios con trazabilidad.
 *****/

using Shared.Kernel.Interfaces;

namespace Empresa.Application.Ministerio.Dtos
{
    public class ActualizarMinisterioRequest : ITrackableRequest
    {
        public int nIdMinisterio { get; set; }
        public string sNombreMinisterio { get; set; } = default!;
        public int nUsuarioModificacion { get; set; }

        public int UsuarioId => nUsuarioModificacion;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_Ministerio";
        public string CampoId => "nMinisterioId";
        public int? ValorId => nIdMinisterio;
        public string Movimiento => "Update";
    }
}
