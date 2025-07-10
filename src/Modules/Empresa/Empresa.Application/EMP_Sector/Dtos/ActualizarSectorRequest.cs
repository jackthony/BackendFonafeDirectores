/*****
 * Nombre del archivo:  ActualizarSectorRequest.cs
 * Descripción:         DTO utilizado para actualizar la información de un sector existente.
 *                      Implementa ITrackableRequest para registrar datos de auditoría como
 *                      el usuario que modifica, el módulo, la tabla y el tipo de operación.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial del archivo.
 *****/

using Shared.Kernel.Interfaces;

namespace Empresa.Application.Sector.Dtos
{
    public class ActualizarSectorRequest : ITrackableRequest
    {
        public int nIdSector { get; set; }
        public string sNombreSector { get; set; } = default!;
        public int nUsuarioModificacion { get; set; }

        public int UsuarioId => nUsuarioModificacion;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_Sector";
        public string CampoId => "nSectorId";
        public int? ValorId => nIdSector;
        public string Movimiento => "Update";
    }
}
