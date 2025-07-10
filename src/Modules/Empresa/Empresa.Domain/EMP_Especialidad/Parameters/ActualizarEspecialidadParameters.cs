/***********
 * Nombre del archivo:  ActualizarEspecialidadParameters.cs
 * Descripci�n:         Clase que encapsula los par�metros necesarios para actualizar una especialidad existente,
 *                      incluyendo datos de auditor�a como usuario y fecha de modificaci�n.
 * Autor:               Daniel Alva
 * Fecha de creaci�n: 02/06/2525
 * �ltima modificaci�02/06/25025 por Daniel Alva
 * Cambios recientes:   Clase creada para gestionar los datos de actualizaci�n de una especialidad.
 ***********/

namespace Empresa.Domain.Especialidad.Parameters
{
    public class ActualizarEspecialidadParameters
    {
        public int EspecialidadId { get; set; }
        public string NombreEspecialidad { get; set; } = default!;
        public int UsuarioModificacionId { get; set; }
        public DateTime FechaModificacion { get; set; }

    }
}
