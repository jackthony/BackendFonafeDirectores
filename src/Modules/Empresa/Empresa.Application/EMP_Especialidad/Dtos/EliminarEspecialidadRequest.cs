/*****
 * Nombre de clase:     EliminarEspecialidadRequest
 * Descripción:         DTO para la solicitud de eliminación de una especialidad.
 *                      Implementa ITrackableRequest para permitir el seguimiento de la acción.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para manejar la eliminación de especialidades con trazabilidad.
 *****/

using Shared.Kernel.Interfaces;

namespace Empresa.Application.Especialidad.Dtos
{
    public class EliminarEspecialidadRequest : ITrackableRequest
    {
        public int nIdEspecialidad { get; set; }
        public int nUsuarioModificacion { get; set; }

        public int UsuarioId => nUsuarioModificacion;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_Especialidad";
        public string CampoId => "nEspecialidadId";
        public int? ValorId => nIdEspecialidad;
        public string Movimiento => "Delete";
    }
}
