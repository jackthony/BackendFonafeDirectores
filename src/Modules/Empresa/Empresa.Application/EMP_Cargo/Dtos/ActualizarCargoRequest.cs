/*****
 * Nombre del archivo:  ActualizarCargoRequest.cs
 * Descripción:         Clase que representa una solicitud para actualizar un cargo en el sistema. 
 *                      Implementa `ITrackableRequest` para rastrear las modificaciones, con propiedades como `nIdCargo`, `sNombreCargo`, y `nUsuarioModificacion`.
 *                      Incluye metadatos sobre el módulo, tabla y campo de la base de datos correspondientes al cargo que se actualizará.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Shared.Kernel.Interfaces;

namespace Empresa.Application.Cargo.Dtos
{
    public class ActualizarCargoRequest : ITrackableRequest
    {
        public int nIdCargo { get; set; }
        public string sNombreCargo { get; set; } = default!;
        public int nUsuarioModificacion { get; set; }

        public int UsuarioId => nUsuarioModificacion;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_Cargo";
        public string CampoId => "nCargoId";
        public int? ValorId => nIdCargo;
        public string Movimiento => "Update";
    }
}
