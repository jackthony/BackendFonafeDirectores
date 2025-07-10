/*****
 * Nombre del archivo:  CrearSectorRequest.cs
 * Descripción:         DTO que representa la solicitud para crear un nuevo sector,
 *                      implementa ITrackableRequest para incluir datos de auditoría
 *                      como usuario que registra, módulo, tabla y tipo de movimiento.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial del archivo.
 *****/

using Shared.Kernel.Interfaces;

namespace Empresa.Application.Sector.Dtos
{
    public class CrearSectorRequest : ITrackableRequest
    {
        public string sNombreSector { get; set; } = default!;
        public int nUsuarioRegistro { get; set; }

        public int UsuarioId => nUsuarioRegistro;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_Sector";
        public string CampoId => "nSectorId";
        public int? ValorId => null;
        public string Movimiento => "Create";
    }
}
