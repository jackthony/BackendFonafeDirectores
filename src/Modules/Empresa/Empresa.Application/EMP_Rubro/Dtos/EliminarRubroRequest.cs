/*****
 * Nombre de clase:     EliminarRubroRequest
 * Descripción:         DTO utilizado para enviar los datos necesarios al eliminar un rubro.
 *                      Implementa ITrackableRequest para auditoría, especificando información
 *                      del módulo, tabla y tipo de movimiento.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para representar la solicitud de eliminación de rubros con trazabilidad.
 *****/

using Shared.Kernel.Interfaces;

namespace Empresa.Application.Rubro.Dtos
{
    public class EliminarRubroRequest : ITrackableRequest
    {
        public int nIdRubro { get; set; }
        public int nUsuarioModificacion { get; set; }

        public int UsuarioId => nUsuarioModificacion;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_Rubro";
        public string CampoId => "nRubroId";
        public int? ValorId => nIdRubro;
        public string Movimiento => "Delete";
    }
}
