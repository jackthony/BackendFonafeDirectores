/*****
 * Nombre del archivo:  EliminarSectorRequest.cs
 * Descripción:         DTO que representa la solicitud para eliminar un sector,
 *                      implementa ITrackableRequest para registrar información de auditoría
 *                      como usuario que realiza la acción, módulo, tabla y tipo de movimiento.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial del archivo.
 *****/

using Shared.Kernel.Interfaces;

namespace Empresa.Application.Sector.Dtos
{
    public class EliminarSectorRequest : ITrackableRequest
    {
        public int nIdSector { get; set; }
        public int nUsuarioModificacion { get; set; }

        public int UsuarioId => nUsuarioModificacion;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_Sector";
        public string CampoId => "nSectorId";
        public int? ValorId => nIdSector;
        public string Movimiento => "Delete";
    }
}
