/*****
 * Nombre de clase:     CrearEspecialidadRequest
 * Descripción:         DTO para la solicitud de creación de una nueva especialidad.
 *                      Implementa ITrackableRequest para permitir el seguimiento de la acción.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para manejar la creación de especialidades con trazabilidad.
 *****/

using Shared.Kernel.Interfaces;

namespace Empresa.Application.Especialidad.Dtos
{
    public class CrearEspecialidadRequest : ITrackableRequest
    {
        public string sNombreEspecialidad { get; set; } = default!;
        public int nUsuarioRegistro { get; set; }

        public int UsuarioId => nUsuarioRegistro;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_Especialidad";
        public string CampoId => "nEspecialidadId";
        public int? ValorId => null;
        public string Movimiento => "Create";
    }
}
