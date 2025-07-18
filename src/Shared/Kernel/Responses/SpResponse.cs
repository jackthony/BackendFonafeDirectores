﻿/***********
 * Nombre del archivo:  SpResult.cs
 * Descripción:         Clase genérica que encapsula el resultado de una operación, como un procedimiento
 *                      almacenado, incluyendo el estado de éxito, un mensaje y un dato de tipo genérico.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 ***********/

namespace Shared.Kernel.Responses
{
    public class SpResult<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public T? Data { get; set; }
    }
}
