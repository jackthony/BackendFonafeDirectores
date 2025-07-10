/*****
 * Nombre de clase:     ActualizarEspecialidadRequest
 * Descripción:         DTO para la solicitud de actualización de una especialidad existente.
 *                      Implementa ITrackableRequest para el seguimiento de la acción de actualización.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para manejar la actualización de especialidades con trazabilidad.
 *****/

using Shared.Kernel.Interfaces;

namespace Empresa.Application.Especialidad.Dtos
{
    public class ActualizarEspecialidadRequest : ITrackableRequest
    {
        public int nIdEspecialidad { get; set; }
        public string sNombreEspecialidad { get; set; } = default!;
        public int nUsuarioModificacion { get; set; }

        public int UsuarioId => nUsuarioModificacion;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_Especialidad";
        public string CampoId => "nEspecialidadId";
        public int? ValorId => nIdEspecialidad;
        public string Movimiento => "Update";
    }
}
