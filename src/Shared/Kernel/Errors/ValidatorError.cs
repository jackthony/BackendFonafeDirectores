/***********
 * Nombre del archivo:  ValidationError.cs
 * Descripción:         Clase que representa un error de validación, derivada de `ErrorBase`. Contiene
 *                      un diccionario opcional con los errores específicos por campo.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 ***********/

namespace Shared.Kernel.Errors
{
    public class ValidationError : ErrorBase
    {
        public Dictionary<string, string[]>? Errors { get; }

        public ValidationError(string code, string message, Dictionary<string, string[]>? errors = null)
            : base(code, message)
        {
            Errors = errors;
        }
    }
}
