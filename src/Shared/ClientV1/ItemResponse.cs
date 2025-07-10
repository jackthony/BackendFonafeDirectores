/***********
 * Nombre del archivo:  ItemResponse.cs
 * Descripción:         Clase genérica que representa una respuesta que contiene un solo elemento.
 *                      Hereda de `BaseResponse` e incluye una propiedad `Item` de tipo especificado.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 ***********/

namespace Shared.ClientV1
{
    public class ItemResponse<T> : BaseResponse
    {
        public T? Item { get; set; }
    }
}
