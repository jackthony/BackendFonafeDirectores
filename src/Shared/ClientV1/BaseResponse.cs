﻿/***********
 * Nombre del archivo:  BaseResponse.cs
 * Descripción:         Clase base abstracta para respuestas en el sistema. Hereda de `BaseRequest` e incluye
 *                      propiedades comunes como el estado de éxito y una lista de errores.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 ***********/

namespace Shared.ClientV1
{
    public abstract class BaseResponse : BaseRequest
    {
        public bool IsSuccess { get; set; } = false;
        public List<string> LstError { get; set; } = [];
    }
}
