/*****
 * Nombre de clase:     CrearMinisterioRequest
 * Descripción:         DTO utilizado para enviar los datos necesarios para registrar un nuevo ministerio.
 *                      Implementa ITrackableRequest para permitir la trazabilidad del movimiento en auditorías,
 *                      especificando información del módulo, tabla y tipo de operación.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para representar la solicitud de creación de ministerios con trazabilidad.
 *****/

using Shared.Kernel.Interfaces;

namespace Empresa.Application.Ministerio.Dtos
{
    public class CrearMinisterioRequest : ITrackableRequest
    {
        public string sNombreMinisterio { get; set; } = default!;
        public int nUsuarioRegistroId { get; set; }

        public int UsuarioId => nUsuarioRegistroId;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_Ministerio";
        public string CampoId => "nMinisterioId";
        public int? ValorId => null;
        public string Movimiento => "Create";
    }
}
