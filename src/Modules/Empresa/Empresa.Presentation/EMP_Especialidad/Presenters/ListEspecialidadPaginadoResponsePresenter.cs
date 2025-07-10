/***********
 * Nombre del archivo:  ListEspecialidadPaginadoResponsePresenter.cs
 * Descripción:         Clase que implementa la interfaz IPresenterDelivery para transformar
 *                      un resultado paginado de EspecialidadResult en un LstItemResponse que contiene
 *                      una lista paginada de EspecialidadResponse, asignando índices
 *                      correspondientes a la paginación y facilitando la entrega paginada
 *                      de datos del módulo Especialidad al cliente.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial del presenter ListEspecialidadPaginadoResponsePresenter.
 ***********/

using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Domain.Especialidad.Results;
using Empresa.Presentation.Especialidad.Mappers;
using Empresa.Presentation.Especialidad.Responses;

namespace Empresa.Presentation.Especialidad.Presenters
{
    public class ListEspecialidadPaginadoResponsePresenter : IPresenterDelivery<PagedResult<EspecialidadResult>, LstItemResponse<EspecialidadResponse>>
    {
        public LstItemResponse<EspecialidadResponse> Present(PagedResult<EspecialidadResult> input)
        {
            int startIndex = (input.Page - 1) * input.PageSize;

            var lista = EspecialidadResponseMapper.ToListResponse(input.Items);
            var listaItems = lista.ToList();
            for (int i = 0; i < listaItems.Count; i++)
            {
                listaItems[i].indice = startIndex + i + 1;
            }
            return new LstItemResponse<EspecialidadResponse>
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
