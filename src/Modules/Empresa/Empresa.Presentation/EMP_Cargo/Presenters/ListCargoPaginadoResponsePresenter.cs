/***********
* Nombre del archivo: ListCargoPaginadoResponsePresenter.cs
* Descripción:        **Implementación del presentador** para transformar un resultado paginado de cargos
*                     (`PagedResult<CargoResult>`) en una respuesta de presentación (`LstItemResponse<CargoResponse>`)
*                     para ser enviada al cliente. Este presentador se encarga de mapear los elementos de la lista
*                     a `CargoResponse` utilizando `CargoResponseMapper.ToListResponse`, asignar un índice secuencial
*                     a cada elemento dentro de la paginación, y construir la estructura de respuesta final
*                     que incluye los datos paginados y la información de la paginación.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase presentadora para listar cargos paginados.
***********/

using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Domain.Cargo.Results;
using Empresa.Presentation.Cargo.Mappers;
using Empresa.Presentation.Cargo.Responses;

namespace Empresa.Presentation.Cargo.Presenters
{
    public class ListCargoPaginadoResponsePresenter : IPresenterDelivery<PagedResult<CargoResult>, LstItemResponse<CargoResponse>>
    {
        public LstItemResponse<CargoResponse> Present(PagedResult<CargoResult> input)
        {
            int startIndex = (input.Page - 1) * input.PageSize;

            var lista = CargoResponseMapper.ToListResponse(input.Items);
            var listaItems = lista.ToList();
            for (int i = 0; i < listaItems.Count; i++)
            {
                listaItems[i].indice = startIndex + i + 1;
            }
            return new LstItemResponse<CargoResponse>
            {
                LstItem = listaItems,
                Pagination = new Pagination
                {
                    PageIndex = input.Page,
                    PageSize = input.PageSize,
                    TotalRows = input.TotalItems
                },
                IsSuccess = true
            };
        }
    }
}
