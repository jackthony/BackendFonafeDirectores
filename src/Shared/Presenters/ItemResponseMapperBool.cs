/***********
 * Nombre del archivo:  ItemResponseMapperBool.cs
 * Descripción:         Presentador que transforma un resultado base (`SpResultBase`) en una respuesta
 *                      estándar con un item de tipo booleano (`ItemResponse<bool>`), evaluando si el dato es mayor a cero.
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
    public class ItemResponseMapperBool : IPresenterDelivery<SpResultBase, ItemResponse<bool>>
    {
        public ItemResponse<bool> Present(SpResultBase input)
        {
            return new ItemResponse<bool>
            {
                IsSuccess = input.Success,
                Item = input.Data > 0
            };
        }
    }
}
