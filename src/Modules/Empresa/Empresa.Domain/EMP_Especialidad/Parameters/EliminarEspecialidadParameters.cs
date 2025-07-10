/***********
 * Nombre del archivo:  EliminarEspecialidadParameters.cs
 * Descripci�n:         Clase que contiene los par�metros necesarios para eliminar una especialidad,
 *                      incluyendo informaci�n de trazabilidad.
 * Autor:               Daniel Alva
 * Fecha de creaci�n: 02/06/2525
 * �ltima modificaci�02/06/25025 por Daniel Alva
 * Cambios recientes:   Clase creada para encapsular los datos de eliminaci�n con trazabilidad.
 ***********/

namespace Empresa.Domain.Especialidad.Parameters
{
    public class EliminarEspecialidadParameters
    {
        public int EspecialidadId { get; set; }
        public int UsuarioModificacionId { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
