/*****
 * Nombre de clase:     ActualizarRubroRequest
 * Descripción:         DTO utilizado para enviar los datos necesarios para actualizar un rubro existente.
 *                      Implementa ITrackableRequest para habilitar la trazabilidad de la modificación.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para representar la solicitud de actualización de rubros con trazabilidad.
 *****/

using Shared.Kernel.Interfaces;

namespace Empresa.Application.Rubro.Dtos
{
    public class ActualizarRubroRequest : ITrackableRequest
    {
        public int nIdRubro { get; set; }
        public string sNombreRubro { get; set; } = default!;
        public int nUsuarioModificacion { get; set; }

        public int UsuarioId => nUsuarioModificacion;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_Rubro";
        public string CampoId => "nRubroId";
        public int? ValorId => nIdRubro;
        public string Movimiento => "Update";
    }
}
