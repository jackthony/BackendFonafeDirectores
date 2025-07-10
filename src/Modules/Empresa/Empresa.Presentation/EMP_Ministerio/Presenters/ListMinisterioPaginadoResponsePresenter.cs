/***********
 * Nombre del archivo:  ListMinisterioPaginadoResponsePresenter.cs
 * Descripción:         Presentador que convierte un resultado paginado de MinisterioResult
 *                      en una respuesta paginada de presentación (LstItemResponse<MinisterioResponse>),
 *                      asignando índices para la paginación y estructurando la respuesta para el cliente.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial del presentador para listado paginado de ministerios.
 ***********/

using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Domain.Ministerio.Results;
using Empresa.Presentation.Ministerio.Mappers;
using Empresa.Presentation.Ministerio.Responses;

namespace Empresa.Presentation.Ministerio.Presenters
{
    public class ListMinisterioPaginadoResponsePresenter : IPresenterDelivery<PagedResult<MinisterioResult>, LstItemResponse<MinisterioResponse>>
    {
        public LstItemResponse<MinisterioResponse> Present(PagedResult<MinisterioResult> input)
        {
            int startIndex = (input.Page - 1) * input.PageSize;

            var lista = MinisterioResponseMapper.ToListResponse(input.Items);
            var listaItems = lista.ToList();
            for (int i = 0; i < listaItems.Count; i++)
            {
                listaItems[i].indice = startIndex + i + 1;
            }
            return new LstItemResponse<MinisterioResponse>
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
