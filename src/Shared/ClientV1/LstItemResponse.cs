/***********
 * Nombre del archivo:  LstItemResponse.cs
 * Descripción:         Clase genérica que representa una respuesta con una lista de elementos paginados.
 *                      Hereda de `BaseResponse` e incluye la colección de ítems y los datos de paginación.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 ***********/

namespace Shared.ClientV1
{
    public class LstItemResponse<T> : BaseResponse
    {
        public IEnumerable<T> LstItem { get; set; } = [];
        public Pagination Pagination { get; set; } = new Pagination();
    }
}
