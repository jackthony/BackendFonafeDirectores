/*****
 * Nombre del archivo:  EliminarDirectorRequest.cs
 * Descripción:         Clase que representa una solicitud para eliminar un director en el sistema. 
 *                      Incluye propiedades como `nDirectorId`, `nUsuarioModificacionId` y `dtFechaModificacion`, que permiten realizar un seguimiento de la eliminación del director.
 *                      Implementa la interfaz `ITrackableRequest` para realizar un seguimiento de los cambios.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Shared.Kernel.Interfaces;

namespace Empresa.Application.Director.Dtos
{
    public class EliminarDirectorRequest : ITrackableRequest
    {
        public int nDirectorId { get; set; }
        public int nUsuarioModificacionId { get; set; }
        public DateTime dtFechaModificacion { get; set; }

        public int UsuarioId => nUsuarioModificacionId;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_Director";
        public string CampoId => "nDirectorId";
        public int? ValorId => nDirectorId;
        public string Movimiento => "Delete";
    }
}
