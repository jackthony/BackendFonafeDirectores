/***********
* Nombre del archivo: ListCargoResponsePresenter.cs
* Descripción:        **Implementación del presentador** para transformar una lista de resultados de dominio de cargos
*                     (`List<CargoResult>`) en una respuesta de presentación (`LstItemResponse<CargoResponse>`)
*                     para ser enviada al cliente. Este presentador se encarga de mapear cada `CargoResult`
*                     a un `CargoResponse` utilizando `CargoResponseMapper.ToListResponse` y de envolver
*                     la lista resultante en una estructura de respuesta estándar que indica éxito.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase presentadora para listar cargos.
***********/

using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Cargo.Results;
using Empresa.Presentation.Cargo.Responses;

namespace Empresa.Presentation.Cargo.Mappers
{
    public class ListCargoResponsePresenter : IPresenterDelivery<List<CargoResult>, LstItemResponse<CargoResponse>>
    {
        public LstItemResponse<CargoResponse> Present(List<CargoResult> input)
        {
            return new LstItemResponse<CargoResponse>
            {
                LstItem = CargoResponseMapper.ToListResponse(input),
                IsSuccess = true
            };
        }
    }
}
