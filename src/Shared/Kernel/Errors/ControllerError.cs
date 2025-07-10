/***********
 * Nombre del archivo:  ControllerError.cs
 * Descripción:         Clase que representa un error generado en el controlador. Hereda de `ErrorBase`
 *                      e incluye un diccionario opcional con detalles adicionales del error por campo.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 ***********/

namespace Shared.Kernel.Errors
{
    public class ControllerError : ErrorBase
    {
        public Dictionary<string, string[]>? Errors { get; }

        public ControllerError(string code, string message, Dictionary<string, string[]>? errors = null)
            : base(code, message)
        {
            Errors = errors;
        }
    }
}
