/***********
 * Nombre del archivo:  ItemResponseMapperInt.cs
 * Descripción:         Presentador que transforma un resultado base (`SpResultBase`) en una respuesta
 *                      estándar con un item de tipo entero (`ItemResponse<int>`).
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 ***********/

using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Shared.Presenters
{
    public class ItemResponseMapperInt : IPresenterDelivery<SpResultBase, ItemResponse<int>>
    {
        public ItemResponse<int> Present(SpResultBase input)
        {
            return new ItemResponse<int>
            {
                IsSuccess = input.Success,
                Item = input.Data,
            };
        }
    }
}
