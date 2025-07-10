/***********
 * Nombre del archivo:  ErrorBase.cs
 * Descripción:         Clase base abstracta para representar errores en el sistema. Contiene propiedades
 *                      comunes como código y mensaje, y métodos estáticos para construir errores específicos
 *                      como validación, base de datos, inesperados o no encontrados.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 ***********/

namespace Shared.Kernel.Errors
{
    public abstract class ErrorBase
    {
        public string Code { get; }
        public string Message { get; }

        protected ErrorBase(string code, string message)
        {
            Code = code;
            Message = message;
        }

        public static ErrorBase Validation(string message, Dictionary<string, string[]>? errors = null)
            => new ValidationError("Validation", message, errors);

        public static ErrorBase Database(string message)
            => new DatabaseError("Database", message);

        public static ErrorBase Unexpected(string message)
            => new UnexpectedError("Unexpected", message);

        public static ErrorBase NotFound()
            => new NotFoundError("NotFound", "No se encontró el elemento");
    }
}
