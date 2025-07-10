/***********
 * Nombre del archivo:  DatabaseError.cs
 * Descripción:         Clase que representa un error relacionado con la base de datos. Hereda de `ErrorBase`
 *                      y se utiliza para identificar fallos en operaciones de persistencia o consultas.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 ***********/

namespace Shared.Kernel.Errors
{
    public class DatabaseError : ErrorBase
    {
        public DatabaseError(string code, string message) : base(code, message) { }
    }
}
