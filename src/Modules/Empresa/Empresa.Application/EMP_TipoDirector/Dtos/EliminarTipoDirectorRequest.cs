/*****
 * Nombre del archivo:  EliminarTipoDirectorRequest.cs
 * Descripción:         DTO que representa la solicitud para eliminar un tipo de director. 
 *                      Implementa la interfaz ITrackableRequest para habilitar el seguimiento
 *                      de auditoría del movimiento realizado sobre la tabla EMP_TipoDirector.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/

using Shared.Kernel.Interfaces;

namespace Empresa.Application.TipoDirector.Dtos
{
    public class EliminarTipoDirectorRequest : ITrackableRequest
    {
        public int nIdTipoDirector { get; set; }
        public int nUsuarioModificacion { get; set; }

        public int UsuarioId => nUsuarioModificacion;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_TipoDirector";
        public string CampoId => "nTipoDirectorId";
        public int? ValorId => nIdTipoDirector;
        public string Movimiento => "Delete";
    }
}
