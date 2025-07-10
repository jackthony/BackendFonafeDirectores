/***********
 * Nombre del archivo:  ITrackableRequest.cs
 * Descripción:         Interfaz que define la estructura para solicitudes trazables, incluyendo información
 *                      del usuario, módulo, tabla, campo clave, valor de referencia y tipo de movimiento.
 *                      Opcionalmente permite incluir detalles adicionales de trazabilidad.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la interfaz.
 ***********/

namespace Shared.Kernel.Interfaces
{
    public interface ITrackableRequest
    {
        public int UsuarioId { get; }
        public string Modulo { get; }
        public string Tabla { get; }
        public string CampoId { get; }
        public int? ValorId { get; }
        public string Movimiento { get; }
        public string? DetallesTrazabilidad => null;
    }
}
