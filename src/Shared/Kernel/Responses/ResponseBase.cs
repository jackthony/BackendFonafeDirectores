/***********
 * Nombre del archivo:  ResponseBase.cs
 * Descripción:         Clase genérica base para respuestas estándar del sistema, incluye información
 *                      sobre el estado de la operación, un mensaje descriptivo y datos del tipo especificado.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 ***********/

namespace Shared.Kernel.Responses
{
    public class ResponseBase<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public T? Data { get; set; }
    }
}
