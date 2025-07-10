/***********
* Nombre del archivo: ObtenerCargoResponsePorIdPresenter.cs
* Descripción:        **Implementación del presentador** para transformar el resultado de un solo cargo
*                     (`CargoResult`) a una respuesta de presentación (`ItemResponse<CargoResponse>`)
*                     para ser enviada al cliente. Este presentador se encarga de envolver el **`CargoResponse`**,
*                     obtenido a través del mapeador `CargoResponseMapper`, dentro de una estructura de respuesta
*                     estándar que indica éxito.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase presentadora para obtener un cargo por ID.
***********/

using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Cargo.Results;
using Empresa.Presentation.Cargo.Responses;

namespace Empresa.Presentation.Cargo.Mappers
{
    public class ObtenerCargoResponsePorIdPresenter : IPresenterDelivery<CargoResult, ItemResponse<CargoResponse>>
    {
        public ItemResponse<CargoResponse> Present(CargoResult input)
        {
            return new ItemResponse<CargoResponse>
            {
                IsSuccess = true,
                Item = CargoResponseMapper.ToResponse(input),
            };
        }
    }
}
