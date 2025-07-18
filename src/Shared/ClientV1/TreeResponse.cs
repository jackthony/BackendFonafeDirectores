﻿/***********
 * Nombre del archivo:  TreeResponse.cs
 * Descripción:         Clase genérica que representa una respuesta en forma de árbol. Hereda de `BaseResponse`
 *                      e incluye una lista de ítems del tipo especificado.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 ***********/

namespace Shared.ClientV1
{
    public class TreeResponse<T> : BaseResponse
    {
        public List<T> LstItem { get; set; } = [];
    }
}
