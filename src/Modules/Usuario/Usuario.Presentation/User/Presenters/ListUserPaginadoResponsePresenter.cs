/***********
 * Nombre del archivo:   ListUserPaginadoResponsePresenter.cs
 * Descripción:          Implementación de un presentador que transforma un 'PagedResult<UserResult>'
 *                       (resultado paginado de dominio) en un 'LstItemResponse<UserResponse>' (respuesta paginada
 *                       para el cliente). Se encarga de formatear la lista de usuarios, añadir el índice de cada
 *                       elemento dentro de la paginación y configurar los metadatos de paginación antes de ser enviada.
 * Autor:                Daniel Alva
 * Fecha de creación:    09/07/2025
 * Última modificación:  09/07/2025 por Daniel Alva
 * Cambios recientes:    Creación inicial de la clase para presentar una lista paginada de respuestas de usuario.
 **********/

using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Domain.User.Results;
using Usuario.Presentation.User.Mappers;
using Usuario.Presentation.User.Responses;

namespace Usuario.Presentation.User.Presenters
{
    public class ListUserPaginadoResponsePresenter : IPresenterDelivery<PagedResult<UserResult>, LstItemResponse<UserResponse>>
    {
        public LstItemResponse<UserResponse> Present(PagedResult<UserResult> input)
        {
            int startIndex = (input.Page - 1) * input.PageSize;

            var lista = UserResponseMapper.ToListResponse(input.Items);
            var listaItems = lista.ToList();
            for (int i = 0; i < listaItems.Count; i++)
            {
                listaItems[i].indice = startIndex + i + 1;
            }

            return new LstItemResponse<UserResponse>
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
