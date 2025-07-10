/*****
 * Nombre del archivo:  EliminarCargoRequest.cs
 * Descripción:         Clase que representa una solicitud para eliminar un cargo en el sistema. 
 *                      Implementa `ITrackableRequest` para rastrear las modificaciones, con propiedades como `nIdCargo` y `nUsuarioModificacion`.
 *                      Incluye metadatos sobre el módulo, tabla y campo de la base de datos correspondientes al cargo que se eliminará.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Shared.Kernel.Interfaces;

namespace Empresa.Application.Cargo.Dtos
{
    public class EliminarCargoRequest : ITrackableRequest
    {
        public int nIdCargo { get; set; }
        public int nUsuarioModificacion { get; set; }

        public int UsuarioId => nUsuarioModificacion;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_Cargo";
        public string CampoId => "nCargoId";
        public int? ValorId => nIdCargo;
        public string Movimiento => "Delete";
    }
}
