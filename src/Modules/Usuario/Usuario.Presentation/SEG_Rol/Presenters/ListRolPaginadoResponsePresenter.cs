/***********
 * Nombre del archivo:  ListRolPaginadoResponsePresenter.cs
 * Descripción:         Presentador encargado de transformar un resultado paginado de dominio (PagedResult<RolResult>)
 *                      en una respuesta de presentación paginada (LstItemResponse<RolResponse>).
 *                      También asigna un índice correlativo a cada ítem de la lista.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación del presentador para el listado paginado de roles.
 ***********/

using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Domain.Rol.Results;
using Usuario.Presentation.Rol.Mappers;
using Usuario.Presentation.Rol.Responses;

namespace Usuario.Presentation.Rol.Presenters
{
    public class ListRolPaginadoResponsePresenter : IPresenterDelivery<PagedResult<RolResult>, LstItemResponse<RolResponse>>
    {
        public LstItemResponse<RolResponse> Present(PagedResult<RolResult> input)
        {
            int startIndex = (input.Page - 1) * input.PageSize;

            var lista = RolResponseMapper.ToListResponse(input.Items);
            var listaItems = lista.ToList();
            for (int i = 0; i < listaItems.Count; i++)
            {
                listaItems[i].indice = startIndex + i + 1;
            }
            return new LstItemResponse<RolResponse>
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
