/***********
 * Nombre del archivo:  ISistemaResponse.cs
 * Descripción:         Interfaz que define propiedades comunes en respuestas del sistema, como el identificador
 *                      del usuario y el ID de sesión, útil para trazabilidad o auditoría.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la interfaz.
 ***********/

namespace Shared.Kernel.Interfaces
{
    public interface ISistemaResponse
    {
        int? UsuarioId { get; }
        string? GetSessionId { get; }
    }
}
