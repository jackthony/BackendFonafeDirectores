/***********
 * Nombre del archivo:  ITrackableResponse.cs
 * Descripción:         Interfaz que define una respuesta con capacidad de rastreo, mediante una propiedad
 *                      identificadora (`ValorId`) que puede ser usada para trazabilidad.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la interfaz.
 ***********/

namespace Shared.Kernel.Interfaces
{
    public interface ITrackableResponse
    {
        public int ValorId { get; }
    }
}
