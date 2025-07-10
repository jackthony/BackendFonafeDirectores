/***********
 * Nombre del archivo:  ValidationProblemDetailsOur.cs
 * Descripción:         Clase que extiende `ProblemDetailsOur` para representar errores de validación
 *                      estructurados, permitiendo agrupar múltiples errores por campo en un diccionario.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 ***********/

namespace Shared.Kernel.Errors
{
    public class ValidationProblemDetailsOur : ProblemDetailsOur
    {
        public IDictionary<string, string[]> Errors { get; set; } = new Dictionary<string, string[]>(StringComparer.Ordinal);

        public ValidationProblemDetailsOur()
        {
        }

        public ValidationProblemDetailsOur(IDictionary<string, string[]> errors)
        {
            if (errors == null)
                throw new ArgumentNullException(nameof(errors));

            foreach (var kvp in errors)
            {
                Errors.Add(kvp.Key, kvp.Value);
            }
        }
    }
}
