/***********
 * Nombre del archivo:  ITrackableResponse.cs
 * Descripción:         Interfaz que define una respuesta con capacidad de rastreo, mediante una propiedad
 *                      identificadora (`ValorId`) que puede ser usada para trazabilidad.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la interfaz.
 ***********/

namespace Shared.Kernel.Interfaces
{
    public interface ITrackableResponse
    {
        public int ValorId { get; }
    }
}
