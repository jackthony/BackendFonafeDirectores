/***********
 * Nombre del archivo:  ISistemaRequest.cs
 * Descripción:         Interfaz que define propiedades comunes en solicitudes del sistema, utilizadas
 *                      para trazabilidad, auditoría o control de estado en la ejecución de operaciones.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la interfaz.
 ***********/

namespace Shared.Kernel.Interfaces
{
    public interface ISistemaRequest
    {
        int? UsuarioId { get; }
        string? Origen { get; }
        int? Estado { get; }
        string? Mensaje { get; }
        string? TipoEvento { get; }
    }
}
