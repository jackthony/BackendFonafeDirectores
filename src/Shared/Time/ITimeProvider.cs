/***********
 * Nombre del archivo:  ITimeProvider.cs
 * Descripción:         Interfaz que define un proveedor de tiempo, incluyendo la hora actual en UTC
 *                      y la hora local de Perú.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la interfaz.
 ***********/

namespace Shared.Time
{
    public interface ITimeProvider
    {
        public DateTime NowPeru { get; }
        public DateTime UtcNow { get; }
    }
}
