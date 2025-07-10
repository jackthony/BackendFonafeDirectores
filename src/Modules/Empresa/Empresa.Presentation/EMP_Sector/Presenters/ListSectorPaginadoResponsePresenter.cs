/***********
 * Nombre del archivo:  ListSectorPaginadoResponsePresenter.cs
 * Descripción:         Presentador encargado de transformar una lista paginada de resultados de sectores
 *                      en una respuesta de tipo `LstItemResponse<SectorResponse>`, incluyendo información
 *                      de paginación y numeración de filas.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación del presentador para listar sectores paginados.
 ***********/

using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Domain.Sector.Results;
using Empresa.Presentation.Sector.Mappers;
using Empresa.Presentation.Sector.Responses;

namespace Empresa.Presentation.Sector.Presenters
{
    public class ListSectorPaginadoResponsePresenter : IPresenterDelivery<PagedResult<SectorResult>, LstItemResponse<SectorResponse>>
    {
        public LstItemResponse<SectorResponse> Present(PagedResult<SectorResult> input)
        {
            int startIndex = (input.Page - 1) * input.PageSize;

            var lista = SectorResponseMapper.ToListResponse(input.Items);
            var listaItems = lista.ToList();
            for (int i = 0; i < listaItems.Count; i++)
            {
                listaItems[i].indice = startIndex + i + 1;
            }
            return new LstItemResponse<SectorResponse>
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
