/***********
 * Nombre del archivo:  UnexpectedError.cs
 * Descripción:         Clase que representa un error inesperado en la aplicación, derivado de `ErrorBase`.
 *                      Se utiliza para manejar excepciones genéricas no controladas.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 ***********/

namespace Shared.Kernel.Errors
{
    public class UnexpectedError : ErrorBase
    {
        public UnexpectedError(string code, string message) : base(code, message) { }
    }
}
