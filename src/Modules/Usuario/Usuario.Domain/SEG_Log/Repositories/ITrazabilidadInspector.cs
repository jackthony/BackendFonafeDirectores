/***********
 * Nombre del archivo:  ITrazabilidadInspector.cs
 * Descripción:         Interfaz que define el contrato para obtener el estado actual
 *                      de un registro en la base de datos, dado el nombre de la tabla,
 *                      el campo identificador y el valor del identificador.
 *                      Se utiliza principalmente para inspección y comparación en la trazabilidad.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Definición inicial para soporte de trazabilidad en auditoría.
 ***********/

namespace Usuario.Domain.SEG_Log.Repositories
{
    public interface ITrazabilidadInspector
    {
        Task<string?> ObtenerEstadoActualAsync(string tabla, string campoId, int valorId);
    }
}
