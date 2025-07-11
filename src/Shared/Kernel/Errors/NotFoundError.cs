﻿/***********
 * Nombre del archivo:  NotFoundError.cs
 * Descripción:         Clase que representa un error de tipo "no encontrado", derivado de `ErrorBase`.
 *                      Se utiliza cuando un recurso solicitado no existe en el sistema.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 ***********/

namespace Shared.Kernel.Errors
{
    public class NotFoundError : ErrorBase
    {
        public NotFoundError(string code, string message)
            : base(code, message)
        {
        }
    }
}
